// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Snac0101.cs" company="Jan-Cornelius Molnar">
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
    public class Snac0101 : Snac
    {
        public Snac0101() : base(0x1, 0x1)
        {
        }

        public ErrorCode ErrorCode { get; set; }

        public TlvErrorSubCode SubError { get; } = new TlvErrorSubCode();

        public override List<byte> Serialize()
        {
            var data = base.Serialize();

            data.AddRange(ByteConverter.GetBytes((uint) ErrorCode));
            data.AddRange(SubError.Serialize());

            return data;
        }

        public override void Deserialize(List<byte> data)
        {
            base.Deserialize(data);

            int index = SizeFixPart;

            ErrorCode = (ErrorCode) (short) ByteConverter.ToUInt16(data.GetRange(index, 2));
            index += 2;

            while (index < data.Count)
            {
                TlvDescriptor desc = TlvDescriptor.GetDescriptor(index, data);

                if (desc.TypeId == 0x8)
                {
                    SubError.Deserialize(data.GetRange(index, desc.TotalSize));
                }
                else if (desc.TypeId == 0x21)
                {
                }

                index += desc.TotalSize;
            }

            TotalSize = index;
        }

        public override int CalculateDataSize()
        {
            return 2 + 6;
        }

        public override string ToString()
        {
            return string.Format("{0} :: {1} {2}", base.ToString(), ErrorCode,
                SubError != null ? SubError.ErrorSubCode.ToString() : "-");
        }
    }
}