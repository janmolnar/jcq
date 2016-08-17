// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SSIBuddyRecord.cs" company="Jan-Cornelius Molnar">
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

using System.Collections.Generic;

namespace Jcq.IcqProtocol.DataTypes
{
    public class SSIBuddyRecord : SSIRecord
    {
        public SSIBuddyRecord() : base(SSIItemType.BuddyRecord)
        {
        }

        public bool AwaitingAuthorization { get; set; }

        public TlvLocalScreenName LocalScreenName { get; } = new TlvLocalScreenName();

        public TlvLocalEmailAddress LocalEmailAddress { get; } = new TlvLocalEmailAddress();

        public TlvLocalSmsNumber LocalSmsNumber { get; } = new TlvLocalSmsNumber();

        public TlvBuddyCommentField Comment { get; } = new TlvBuddyCommentField();

        public TlvPersonalBuddyAlerts PersonalAlerts { get; } = new TlvPersonalBuddyAlerts();

        public override int CalculateDataSize()
        {
            return 0;
        }

        public override void Deserialize(List<byte> data)
        {
            base.Deserialize(data);

            int index = SizeFixPart;

            while (index < data.Count)
            {
                TlvDescriptor desc = TlvDescriptor.GetDescriptor(index, data);

                switch (desc.TypeId)
                {
                    case 0x66:
                        AwaitingAuthorization = true;
                        break;
                    case 0x131:
                        LocalScreenName.Deserialize(data.GetRange(index, desc.TotalSize));
                        break;
                    case 0x137:
                        LocalEmailAddress.Deserialize(data.GetRange(index, desc.TotalSize));
                        break;
                    case 0x13a:
                        LocalSmsNumber.Deserialize(data.GetRange(index, desc.TotalSize));
                        break;
                    case 0x13c:
                        Comment.Deserialize(data.GetRange(index, desc.TotalSize));
                        break;
                    case 0x13d:
                        PersonalAlerts.Deserialize(data.GetRange(index, desc.TotalSize));
                        break;
                }

                index += desc.TotalSize;
            }
        }
    }
}