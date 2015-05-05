// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequestAuthenticationCookieTask.cs" company="Jan-Cornelius Molnar">
// Copyright 2008-2015 Jan Molnar <jan.molnar@me.com>
// 
// This file is part of JCQ.
// JCQ is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your [option]) any later version.
// JCQ is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with JCQ. If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Jcq.IcqProtocol.Internal;
using JCsTools.Core;
using JCsTools.Core.Interfaces;
using JCsTools.JCQ.IcqInterface.DataTypes;
using JCsTools.JCQ.IcqInterface.Interfaces;

namespace JCsTools.JCQ.IcqInterface
{
    /// <summary>
    ///     This task requests an authentication cookie for a username and a password.
    /// </summary>
    public class RequestAuthenticationCookieTask : BasicAsyncTask, ITaskWithState<RequestAuthenticationCookieState>
    {
        private readonly IcqConnector _Connector;
        private readonly IPasswordCredential _PasswordCredential;
        private readonly RequestAuthenticationCookieState _State;

        public RequestAuthenticationCookieTask(IcqConnector owner, IPasswordCredential credential)
        {
            _Connector = owner;
            _State = new RequestAuthenticationCookieState();
            _PasswordCredential = credential;

            Connector.FlapReceived += OnFlapReceived;
        }

        /// <summary>
        ///     Gets the connector used to process this task.
        /// </summary>
        public IcqConnector Connector
        {
            get { return _Connector; }
        }

        /// <summary>
        ///     Gets the password credential used to request the authentication cookie.
        /// </summary>
        public IPasswordCredential PasswordCredential
        {
            get { return _PasswordCredential; }
        }

        /// <summary>
        ///     Gets the current state of the task.
        /// </summary>
        public RequestAuthenticationCookieState State
        {
            get { return _State; }
        }

        protected override void SetCompleted()
        {
            base.SetCompleted();

            // When the task is completed we don't have to listen for new
            // flaps anymore.
            Connector.FlapReceived -= OnFlapReceived;
        }

        protected override void PerformOperation()
        {
            // The only required operation is sending the cookie request
            SendAuthenticationCookieRequest(PasswordCredential.Password);
        }

        /// <summary>
        ///     Filters FalpReceived events and passes the appropiate data to analyzation methods.
        /// </summary>
        private void OnFlapReceived(object sender, FlapTransportEventArgs e)
        {
            var flap = e.Flap;

            try
            {
                // we can ignore flaps other than connection closed negotiations
                if (flap.Channel != FlapChannel.CloseConnectionNegotiation)
                    return;

                AnalyzeConnectionClosedFlap(flap);
            }
            catch (Exception ex)
            {
                Kernel.Exceptions.PublishException(ex);
            }
        }

        /// <summary>
        ///     Analyzes connection closed negotiation flaps.
        /// </summary>
        private void AnalyzeConnectionClosedFlap(Flap flap)
        {
            var tlvsByTypeNumer = default(Dictionary<int, Tlv>);

            // we are only interested in tlvs and their type number.
            tlvsByTypeNumer =
                (from x in flap.DataItems where x is Tlv select (Tlv) x).ToDictionary(tlv => tlv.TypeNumber);

            if (tlvsByTypeNumer.ContainsKey(0x5) & tlvsByTypeNumer.ContainsKey(0x6))
            {
                // if these tlvs are present the authentication succeeded and everything is okay :)

                dynamic bosServerTlv = (TlvBosServerAddress) tlvsByTypeNumer[0x5];
                dynamic authCookieTlv = (TlvAuthorizationCookie) tlvsByTypeNumer[0x6];

                State.BosServerAddress = bosServerTlv.BosServerAddress;
                State.AuthCookie = authCookieTlv.AuthorizationCookie;
                State.AuthenticationSucceeded = true;

                SetCompleted();
            }
            else if (tlvsByTypeNumer.ContainsKey(0x8))
            {
                // if this tlv is present the authentication has failed.

                dynamic authFailedTlv = (TlvAuthFailed) tlvsByTypeNumer[0x8];

                Kernel.Logger.Log("IcqConnector", TraceEventType.Error, "Connection to server failed. ErrorSubCode: {0}",
                    authFailedTlv.ErrorSubCode.ToString);

                State.AuthenticationSucceeded = false;
                State.AuthenticationError = authFailedTlv.ErrorSubCode;

                SetCompleted();
            }
            else
            {
                // in all other cases something went wrong ...
                State.AuthenticationSucceeded = false;

                SetCompleted();
            }
        }

        /// <summary>
        ///     Sends an authentication cookie request to the server.
        /// </summary>
        private void SendAuthenticationCookieRequest(string password)
        {
            var flapRequestCookie = new FlapRequestSignInCookie();

            // TODO: Supply correct client information.
            flapRequestCookie.ScreenName.Uin = Connector.Context.Identity.Identifier;
            flapRequestCookie.Password.Password = password;
            flapRequestCookie.ClientIdString.ClientIdString = "SomeClientSoftware";
            flapRequestCookie.ClientId.ClientId = 8123;
            flapRequestCookie.ClientMajorVersion.ClientMajorVersion = 3;
            flapRequestCookie.ClientMinorVersion.ClientMinorVersion = 9;
            flapRequestCookie.ClientLesserVersion.ClientLesserVersion = 7;
            flapRequestCookie.ClientBuildNumber.ClientBuildNumber = 8;
            flapRequestCookie.ClientDistributionNumber.ClientDistributionNumber = 1;
            flapRequestCookie.ClientLanguage.ClientLanguage = "en";
            flapRequestCookie.ClientCountry.ClientCountry = "us";

            Connector.Send(flapRequestCookie);
        }
    }
}