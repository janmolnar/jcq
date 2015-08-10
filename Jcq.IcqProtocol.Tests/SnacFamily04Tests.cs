// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnacFamily04Tests.cs" company="Jan-Cornelius Molnar">
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

using Jcq.IcqProtocol.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jcq.IcqProtocol.Tests
{
    [TestClass]
    public class SnacFamily04Tests
    {
        //[TestMethod]
        //public void Snac0401DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x2A, 0x02, 0xEF, 0xD9, 0x00, 0x0C, 0x00, 0x04, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x14, 
        //        0x00, 0x0E
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac0401>(f);

        //    Assert.Inconclusive("Verify that Snac0401 was deserialized correctly.");
        //}

        [TestMethod]
        public void Snac0402DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x33, 0x73, 0x00, 0x1A, 0x00, 0x04, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x1F, 0x40, 0x03, 0xE7, 0x03, 0xE7, 0x00, 0x00, 0x00, 0x00
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac0402>(f);

            Assert.Inconclusive("Verify that Snac0402 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac0403DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x31, 0x6F, 0x00, 0x0A, 0x00, 0x04, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac0403>(f);

            Assert.Inconclusive("Verify that Snac0403 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac0404DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x33, 0x6F, 0x00, 0x0A, 0x00, 0x04, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac0404>(f);

            Assert.Inconclusive("Verify that Snac0404 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac0405DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x38, 0xC2, 0x00, 0x1A, 0x00, 0x04, 0x00, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04,
                0x00, 0x02, 0x00, 0x00, 0x00, 0x03, 0x02, 0x00, 0x03, 0xE7, 0x03, 0xE7, 0x00, 0x00, 0x03, 0xE8
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac0405>(f);

            Assert.Inconclusive("Verify that Snac0405 was deserialized correctly.");
        }

        //[TestMethod]
        //public void Snac0406DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x02, 0x23, 
        //        0x00, 0x47, 0x00, 0x04, 0x00, 0x06, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 
        //        0x67, 
        //        0x15, 0x01, 
        //        0x00, 0x00, 0x00, 0x01, 0x07, 0x31, 0x30, 0x30, 0x30, 0x30, 
        //        0x00, 
        //        0x30, 0x30, 0x00, 0x02, 0x00, 0x23, 0x05, 0x01, 0x00, 0x01, 0x01, 0x01, 0x01, 0x00, 
        //        0x00, 
        //        0x00, 
        //        0x74, 0x65, 0x73, 0x74, 0x20, 0x63, 0x68, 0x61, 
        //        0x65, 
        //        0x20, 
        //        0x31, 0x20, 
        //        0x65, 0x73, 0x73, 0x61, 0x67, 0x65, 0x00, 0x06, 0x00, 0x00
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac0406>(f);

        //    Assert.Inconclusive("Verify that Snac0406 was deserialized correctly.");
        //}

        [TestMethod]
        public void Snac0406DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x36, 0x87, 0x00, 0x99, 0x00, 0x04, 0x00, 0x06, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x06,
                0xCC, 0xEB, 0x54, 0x00, 0xF7, 0x07, 0x00, 0x00, 0x00, 0x02, 0x09, 0x31, 0x32, 0x33, 0x34, 0x35,
                0x36, 0x37, 0x38, 0x39, 0x00, 0x05, 0x00, 0x73, 0x00, 0x00, 0xCC, 0xEB, 0x54, 0x00, 0xF7, 0x07,
                0x00, 0x00, 0x09, 0x46, 0x13, 0x49, 0x4C, 0x7F, 0x11, 0xD1, 0x82, 0x22, 0x44, 0x45, 0x53, 0x54,
                0x00, 0x00, 0x00, 0x0A, 0x00, 0x02, 0x00, 0x01, 0x00, 0x0F, 0x00, 0x00, 0x27, 0x11, 0x00, 0x4B,
                0x1B, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0xFB, 0xFF, 0x0E, 0x00, 0xFB,
                0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
                0x00, 0x21, 0x00, 0x0E, 0x00, 0x54, 0x65, 0x73, 0x74, 0x20, 0x6D, 0x65, 0x73, 0x73, 0x61, 0x67,
                0x65, 0x2E, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x03, 0x00, 0x00
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac0406>(f);

            Assert.Inconclusive("Verify that Snac0406 was deserialized correctly.");
        }

        //[TestMethod]
        //public void Snac0406DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x02, 0x56, 
        //        0x00, 
        //        0x00, 
        //        0x00, 0x06, 0x00, 0x00, 0x00, 
        //        0x00, 0x06, 
        //        0x01, 0x33, 0x28, 0x00, 
        //        0x00, 0x04, 0x07, 0x31, 0x30, 0x30, 0x30, 0x30, 
        //        0x00, 
        //        0x30, 0x30, 0x00, 0x05, 0x00, 
        //        0x00, 0x04, 0x00, 0x43, 0x00, 0x54, 0x68, 
        //        0x69, 0x73, 0x20, 0x69, 0x73, 0x20, 0x74, 
        //        0x65, 0x20, 0x74, 0x65, 0x73, 0x74, 0x20, 0x75, 
        //        0x72, 
        //        0x20, 
        //        0x65, 0x73, 0x73, 
        //        0x67, 0x65, 0x20, 0x74, 
        //        0x20, 0x61, 
        //        0x20, 
        //        0x64, 0x20, 0x63, 
        //        0x65, 
        //        0x74, 
        //        0x68, 0x74, 0x74, 0x70, 
        //        0x68, 0x74, 0x74, 0x70, 
        //        0x74, 0x65, 0x73, 0x74, 
        //        0x75, 0x72, 
        //        0x00, 0x00, 0x06, 0x00, 0x00
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac0406>(f);

        //    Assert.Inconclusive("Verify that Snac0406 was deserialized correctly.");
        //}

        //[TestMethod]
        //public void Snac0407Channel1DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x02, 
        //        0x00, 0x66, 0x00, 0x04, 0x00, 0x07, 0x00, 0x00, 
        //        0x91, 
        //        0x00, 0x01, 0x07, 0x31, 0x30, 0x30, 0x30, 0x30, 
        //        0x00, 
        //        0x30, 0x30, 0x00, 0x00, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x50, 0x00, 0x06, 0x00, 0x04, 
        //        0x00, 0x01, 0x00, 0x00, 0x00, 
        //        0x00, 0x04, 0x00, 0x00, 0x04, 0x66, 0x00, 0x03, 0x00, 0x04, 
        //        0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x24, 0x05, 0x01, 0x00, 0x01, 0x00, 0x01, 0x01, 0x00, 
        //        0x00, 0x00, 0x00, 0x00, 0x74, 0x65, 0x73, 0x74, 0x20, 0x70, 
        //        0x61, 0x69, 
        //        0x74, 0x65, 0x78, 0x74, 0x20, 
        //        0x65, 0x73, 0x73, 0x61, 0x67, 0x65
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac0407>(f);

        //    Assert.Inconclusive("Verify that Snac0407 was deserialized correctly.");
        //}

        [TestMethod]
        public void Snac0407Channel2DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x08, 0x2C, 0x01, 0x9D, 0x00, 0x04, 0x00, 0x07, 0x00, 0x00, 0x90, 0x2F, 0x30, 0x11,
                0x70, 0x95, 0xA0, 0x00, 0x26, 0x1F, 0x00, 0x00, 0x00, 0x02, 0x07, 0x31, 0x32, 0x33, 0x34, 0x35,
                0x36, 0x37, 0x00, 0x00, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x50, 0x00, 0x06, 0x00, 0x04,
                0x20, 0x12, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x04, 0x00, 0x00, 0x06, 0xF3, 0x00, 0x03, 0x00, 0x04,
                0x40, 0x5A, 0x93, 0x78, 0x00, 0x05, 0x01, 0x5B, 0x00, 0x00, 0x70, 0x95, 0xA0, 0x00, 0x26, 0x1F,
                0x00, 0x00, 0x09, 0x46, 0x13, 0x49, 0x4C, 0x7F, 0x11, 0xD1, 0x82, 0x22, 0x44, 0x45, 0x53, 0x54,
                0x00, 0x00, 0x00, 0x0A, 0x00, 0x02, 0x00, 0x01, 0x00, 0x0F, 0x00, 0x00, 0x27, 0x11, 0x01, 0x33,
                0x1B, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0xE3, 0xFF, 0x0E, 0x00, 0xE3,
                0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
                0x00, 0x21, 0x00, 0xCC, 0x00, 0x7B, 0x5C, 0x72, 0x74, 0x66, 0x31, 0x5C, 0x61, 0x6E, 0x73, 0x69,
                0x5C, 0x61, 0x6E, 0x73, 0x69, 0x63, 0x70, 0x67, 0x31, 0x32, 0x35, 0x31, 0x5C, 0x64, 0x65, 0x66,
                0x66, 0x30, 0x5C, 0x64, 0x65, 0x66, 0x6C, 0x61, 0x6E, 0x67, 0x31, 0x30, 0x34, 0x39, 0x7B, 0x5C,
                0x66, 0x6F, 0x6E, 0x74, 0x74, 0x62, 0x6C, 0x7B, 0x5C, 0x66, 0x30, 0x5C, 0x66, 0x6E, 0x69, 0x6C,
                0x5C, 0x66, 0x63, 0x68, 0x61, 0x72, 0x73, 0x65, 0x74, 0x32, 0x30, 0x34, 0x7B, 0x5C, 0x2A, 0x5C,
                0x66, 0x6E, 0x61, 0x6D, 0x65, 0x20, 0x4D, 0x53, 0x20, 0x53, 0x61, 0x6E, 0x73, 0x20, 0x53, 0x65,
                0x72, 0x69, 0x66, 0x3B, 0x7D, 0x4D, 0x53, 0x20, 0x53, 0x68, 0x65, 0x6C, 0x6C, 0x20, 0x44, 0x6C,
                0x67, 0x3B, 0x7D, 0x7D, 0x0D, 0x0A, 0x7B, 0x5C, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x74, 0x62, 0x6C,
                0x20, 0x3B, 0x5C, 0x72, 0x65, 0x64, 0x30, 0x5C, 0x67, 0x72, 0x65, 0x65, 0x6E, 0x30, 0x5C, 0x62,
                0x6C, 0x75, 0x65, 0x30, 0x3B, 0x7D, 0x0D, 0x0A, 0x5C, 0x76, 0x69, 0x65, 0x77, 0x6B, 0x69, 0x6E,
                0x64, 0x34, 0x5C, 0x75, 0x63, 0x31, 0x5C, 0x70, 0x61, 0x72, 0x64, 0x5C, 0x63, 0x66, 0x31, 0x5C,
                0x66, 0x30, 0x5C, 0x66, 0x73, 0x32, 0x30, 0x3C, 0x23, 0x23, 0x69, 0x63, 0x71, 0x69, 0x6D, 0x61,
                0x67, 0x65, 0x30, 0x30, 0x30, 0x38, 0x3E, 0x5C, 0x70, 0x61, 0x72, 0x0D, 0x0A, 0x7D, 0x0D, 0x0A,
                0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00, 0x26, 0x00, 0x00, 0x00, 0x7B, 0x39, 0x37,
                0x42, 0x31, 0x32, 0x37, 0x35, 0x31, 0x2D, 0x32, 0x34, 0x33, 0x43, 0x2D, 0x34, 0x33, 0x33, 0x34,
                0x2D, 0x41, 0x44, 0x32, 0x32, 0x2D, 0x44, 0x36, 0x41, 0x42, 0x46, 0x37, 0x33, 0x46, 0x31, 0x34,
                0x39, 0x32, 0x7D
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac0407>(f);

            Assert.Inconclusive("Verify that Snac0407 was deserialized correctly.");
        }

        //[TestMethod]
        //public void Snac0407DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x02, 
        //        0x00, 
        //        0x00, 0x04, 0x00, 0x07, 0x00, 0x00, 
        //        0x59, 0x65, 
        //        0x56, 0x00, 0x04, 0x07, 0x31, 0x30, 0x30, 0x30, 0x30, 
        //        0x00, 
        //        0x30, 0x30, 0x00, 0x00, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x50, 0x00, 0x06, 0x00, 0x04, 
        //        0x00, 0x01, 0x00, 0x00, 0x00, 
        //        0x00, 0x04, 0x00, 0x00, 0x00, 
        //        0x00, 0x03, 0x00, 0x04, 
        //        0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x28, 0x40, 0x42, 
        //        0x00, 0x04, 0x00, 0x20, 0x00, 
        //        0x55, 0x72, 
        //        0x20, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 
        //        0x68, 0x74, 0x74, 0x70, 
        //        0x74, 0x65, 0x73, 0x74, 
        //        0x75, 0x72, 
        //        0x00
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac0407>(f);

        //    Assert.Inconclusive("Verify that Snac0407 was deserialized correctly.");
        //}

        //[TestMethod]
        //public void Snac0408DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x2A, 0x02, 0x7D, 0x6E, 0x00, 0x1B, 0x00, 0x04, 0x00, 0x08, 0x00, 0x00, 0x00, 0x1B, 0x00, 0x08, 
        //        0x00, 0x00, 0x0E, 0x73, 0x77, 0x65, 0x65, 0x74, 0x67, 0x69, 0x72, 0x6C, 0x33, 0x38, 0x34, 0x36, 
        //        0x46, 
        //        0x32
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac0408>(f);

        //    Assert.Inconclusive("Verify that Snac0408 was deserialized correctly.");
        //}

        //[TestMethod]
        //public void Snac0409DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x2A, 0x02, 0xD5, 0xB8, 0x00, 0x0E, 0x00, 0x04, 0x00, 0x09, 0x00, 0x00, 0x00, 0x17, 0x00, 0x08, 
        //        0x00, 0xC8, 0x01, 0xED
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac0409>(f);

        //    Assert.Inconclusive("Verify that Snac0409 was deserialized correctly.");
        //}

        [TestMethod]
        public void Snac040ADeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x12, 0x05, 0x00, 0x38, 0x00, 0x04, 0x00, 0x0A, 0x00, 0x00, 0x8E, 0x36, 0xC7, 0xB1,
                0x00, 0x02, 0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x35, 0x00, 0x00, 0x00, 0x04, 0x00, 0x01,
                0x00, 0x02, 0x00, 0x06, 0x00, 0x04, 0x00, 0x02, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x04, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x03, 0x00, 0x04, 0x3D, 0xE7, 0x38, 0x8B, 0x00, 0x01, 0x00, 0x01
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac040A>(f);

            Assert.Inconclusive("Verify that Snac040A was deserialized correctly.");
        }

        [TestMethod]
        public void Snac040BDeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x54, 0x28, 0x00, 0x6E, 0x00, 0x04, 0x00, 0x0B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0B,
                0xF3, 0x3A, 0xC1, 0x0C, 0x70, 0x18, 0x00, 0x00, 0x00, 0x02, 0x07, 0x36, 0x32, 0x31, 0x38, 0x38,
                0x39, 0x35, 0x00, 0x03, 0x1B, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x07,
                0x00, 0x0E, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0xE9, 0x03, 0x00, 0x00, 0x00, 0x00, 0x1B, 0x00, 0x55, 0x73, 0x65, 0x72, 0x20, 0x69, 0x73,
                0x20, 0x63, 0x75, 0x72, 0x72, 0x65, 0x6E, 0x74, 0x6C, 0x79, 0x20, 0x4F, 0x63, 0x63, 0x75, 0x70,
                0x69, 0x65, 0x64, 0x00
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac040B>(f);

            Assert.Inconclusive("Verify that Snac040B was deserialized correctly.");
        }

        //[TestMethod]
        //public void Snac040BDeserializeTest()
        //{
        //    var data = new byte[]
        //    {

        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac040B>(f);

        //    Assert.Inconclusive("Verify that Snac040B was deserialized correctly.");
        //}

        //[TestMethod]
        //public void Snac040BDeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x2A, 0x02, 0x54, 0x28, 0x00, 0x6E, 0x00, 0x04, 0x00, 0x0B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0B, 
        //        0xF3, 0x3A, 0xC1, 0x0C, 0x70, 0x18, 0x00, 0x00, 0x00, 0x02, 0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 
        //        0x88, 
        //        0x39, 0x35, 0x00, 0x03, 0x1B, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        //        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x07, 
        //        0x00, 0x0E, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
        //        0x00, 0xE9, 0x03, 0x00, 0x00, 0x00, 0x00, 0x1B, 0x00, 0x55, 0x73, 0x65, 0x72, 0x20, 0x69, 0x73, 
        //        0x20, 0x63, 0x75, 0x72, 0x72, 0x65, 0x6E, 0x74, 0x6C, 0x79, 0x20, 0x4F, 0x63, 0x63, 0x75, 0x70, 
        //        0x69, 0x65, 0x64, 0x00
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac040B>(f);

        //    Assert.Inconclusive("Verify that Snac040B was deserialized correctly.");
        //}

        [TestMethod]
        public void Snac040CDeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x39, 0x37, 0x00, 0x1D, 0x00, 0x04, 0x00, 0x0C, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x06,
                0xAB, 0xA5, 0xF5, 0x29, 0x29, 0x1D, 0x00, 0x00, 0x00, 0x02, 0x08, 0x35, 0x32, 0x39, 0x34, 0x33,
                0x31, 0x32, 0x37
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac040C>(f);

            Assert.Inconclusive("Verify that Snac040C was deserialized correctly.");
        }

        [TestMethod]
        public void Snac0414DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x38, 0xC2, 0x00, 0x1E, 0x00, 0x04, 0x00, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00, 0x14,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x07, 0x36, 0x32, 0x31, 0x38, 0x38,
                0x39, 0x35, 0x00, 0x02
            };

            var f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac0414>(f);

            Assert.Inconclusive("Verify that Snac0414 was deserialized correctly.");
        }
    }
}