// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Snac0406.cs" company="Jan-Cornelius Molnar">
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

namespace JCsTools.JCQ.IcqInterface.DataTypes
{
    public class Snac0406 : Snac
    {
        private readonly TlvMessageData _MessageData = new TlvMessageData();

        public Snac0406() : base(0x4, 0x6)
        {
        }

        public long CookieID { get; set; }
        public MessageChannel Channel { get; set; }
        public string ScreenName { get; set; }

        public TlvMessageData MessageData
        {
            get { return _MessageData; }
        }

        public bool RequestAnAckFromServer { get; set; }
        public bool StoreMessageIfRecipientIsOffline { get; set; }

        public override int CalculateDataSize()
        {
            return 8 + 2 + 1 + ScreenName.Length + _MessageData.CalculateTotalSize() + (RequestAnAckFromServer
                ? 4
                : 0) + (StoreMessageIfRecipientIsOffline ? 4 : 0);
        }

        public override void Deserialize(List<byte> data)
        {
            throw new NotImplementedException();
        }

        public override List<byte> Serialize()
        {
            if (Channel != MessageChannel.Channel1PlainText)
                throw new NotImplementedException();

            var data = base.Serialize();

            data.AddRange(ByteConverter.GetBytes((ulong) CookieID));
            data.AddRange(ByteConverter.GetBytes((ushort) Channel));
            data.Add((byte) ScreenName.Length);
            data.AddRange(ByteConverter.GetBytes(ScreenName));

            data.AddRange(_MessageData.Serialize());

            if (RequestAnAckFromServer)
            {
                data.AddRange((new TlvRequestAckFromServer()).Serialize());
            }

            if (StoreMessageIfRecipientIsOffline)
            {
                data.AddRange((new TlvStoreMessageIfRecipientOffline()).Serialize());
            }

            return data;
        }
    }
}