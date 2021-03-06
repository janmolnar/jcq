// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddContactTransaction.cs" company="Jan-Cornelius Molnar">
// The MIT License (MIT)
// 
// Copyright (c) 2015 Jan-Cornelius Molnar
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Jcq.IcqProtocol.DataTypes;

namespace Jcq.IcqProtocol
{
    public class AddContactTransaction : BaseSsiTransaction
    {
        public AddContactTransaction(IcqStorageService owner, IcqContact contact, IcqGroup group) : base(owner)
        {
            Contact = contact;
            Group = group;
        }

        public IcqContact Contact { get; }

        public IcqGroup Group { get; }

        public override Snac CreateSnac()
        {
            var item = new SSIBuddyRecord
            {
                ItemName = Contact.Identifier,
                ItemId = Service.GetNextSsiItemId(),
                GroupId = Group.GroupId
            };

            var data = new Snac1308();
            data.BuddyRecords.Add(item);

            return data;
        }

        public override void OnComplete(SSIActionResultCode action)
        {
            switch (action)
            {
                case SSIActionResultCode.Success:
                    Service.InnerAddContactToStorage(Contact, Group);
                    break;
                default:
                    throw new InvalidOperationException(string.Format("Cannot add contact '{0}' {1}: {2}", Contact.Name,
                        Contact.Identifier, action));
            }
        }

        public override void Validate()
        {
            if (Contact.ItemId > 0)
                throw new InvalidOperationException("Cannot add a contact which is already member of the contact list.");
        }
    }
}