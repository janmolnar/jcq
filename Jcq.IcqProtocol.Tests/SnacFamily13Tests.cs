// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnacFamily13Tests.cs" company="Jan-Cornelius Molnar">
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
    public class SnacFamily13Tests
    {
        //[TestMethod]
        //public void Snac1301DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x2A, 0x02, 0xE1, 0xCD, 0x00, 0x0C, 0x00, 0x13, 0x00, 0x01, 0x00, 0x00, 0x7D, 0x39, 0x33, 0x67, 
        //        0x00, 0x0E
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac1301>(f);

        //    Assert.Inconclusive("Verify that Snac1301 was deserialized correctly.");
        //}

        [TestMethod]
        public void Snac1302DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x22, 0x96, 0x00, 0x0A, 0x00, 0x13, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1302>(f);

            Assert.Inconclusive("Verify that Snac1302 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1303DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x38, 0xC4, 0x00, 0x56, 0x00, 0x13, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02,
                0x00, 0x04, 0x00, 0x2A, 0x02, 0x58, 0x00, 0x33, 0x00, 0x80, 0x00, 0x80, 0x00, 0x01, 0x00, 0x01,
                0x00, 0x32, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80,
                0x00, 0x80, 0x00, 0x14, 0x00, 0xC8, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x02,
                0x00, 0x02, 0x00, 0xFE, 0x00, 0x03, 0x00, 0x02, 0x01, 0xFC, 0x00, 0x05, 0x00, 0x02, 0x00, 0x00,
                0x00, 0x06, 0x00, 0x02, 0x00, 0x61, 0x00, 0x07, 0x00, 0x02, 0x00, 0x0A
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1303>(f);

            Assert.Inconclusive("Verify that Snac1303 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1304DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x22, 0x96, 0x00, 0x0A, 0x00, 0x13, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1304>(f);

            Assert.Inconclusive("Verify that Snac1304 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1305DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x33, 0x6C, 0x00, 0x10, 0x00, 0x13, 0x00, 0x05, 0x00, 0x00, 0x00, 0x01, 0x00, 0x05,
                0x3D, 0xE7, 0x48, 0x17, 0x00, 0xBB
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1305>(f);

            Assert.Inconclusive("Verify that Snac1305 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1306DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0xC1, 0x12, 0x00, 0xE1, 0x00, 0x13, 0x00, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0d,
                0x00, 0x00, 0x08, 0x00, 0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x37, 0x0A, 0x1E, 0x43, 0x18,
                0x00, 0x00, 0x00, 0x0A, 0x01, 0x31, 0x00, 0x06, 0x46, 0x75, 0x6E, 0x42, 0x6F, 0x6F, 0x00, 0x09,
                0x31, 0x37, 0x36, 0x33, 0x33, 0x33, 0x30, 0x37, 0x38, 0x17, 0xB7, 0x2A, 0x18, 0x00, 0x00, 0x00,
                0x09, 0x01, 0x31, 0x00, 0x05, 0x45, 0x2E, 0x53, 0x2E, 0x56, 0x00, 0x07, 0x36, 0x32, 0x31, 0x38,
                0x38, 0x39, 0x38, 0x23, 0x8C, 0x12, 0xA1, 0x00, 0x00, 0x00, 0x09, 0x01, 0x31, 0x00, 0x05, 0x74,
                0x68, 0x6F, 0x72, 0x64, 0x00, 0x07, 0x46, 0x72, 0x69, 0x65, 0x6E, 0x64, 0x73, 0x7F, 0xED, 0x00,
                0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x0A, 0x43, 0x6F, 0x2D, 0x57, 0x6F, 0x72, 0x6B, 0x65, 0x72,
                0x73, 0x55, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x07, 0x36, 0x32, 0x31, 0x38, 0x38,
                0x39, 0x35, 0x23, 0x8C, 0x08, 0x80, 0x00, 0x00, 0x00, 0x0D, 0x01, 0x31, 0x00, 0x09, 0x52, 0x65,
                0x67, 0x72, 0x65, 0x73, 0x73, 0x6F, 0x72, 0x00, 0x07, 0x36, 0x32, 0x35, 0x31, 0x37, 0x32, 0x33,
                0x23, 0x8C, 0x05, 0x83, 0x00, 0x00, 0x00, 0x0D, 0x01, 0x31, 0x00, 0x05, 0x47, 0x68, 0x6F, 0x73,
                0x74, 0x00, 0x66, 0x00, 0x00, 0x00, 0x07, 0x36, 0x32, 0x31, 0x33, 0x39, 0x34, 0x39, 0x23, 0x8C,
                0x26, 0x9A, 0x00, 0x00, 0x00, 0x0D, 0x01, 0x31, 0x00, 0x05, 0x6D, 0x69, 0x63, 0x6B, 0x79, 0x00,
                0x66, 0x00, 0x00, 0x3B, 0xB7, 0x4B, 0x7D
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1306>(f);

            Assert.Inconclusive("Verify that Snac1306 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1307DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x33, 0x71, 0x00, 0x0A, 0x00, 0x13, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1307>(f);

            Assert.Inconclusive("Verify that Snac1307 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1308DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x2C, 0xAA, 0x00, 0x56, 0x00, 0x13, 0x00, 0x08, 0x00, 0x00, 0x00, 0x03, 0x00, 0x08,
                0x00, 0x06, 0x46, 0x61, 0x6D, 0x69, 0x6C, 0x79, 0x0A, 0x1E, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06,
                0x00, 0xC8, 0x00, 0x02, 0x43, 0x18, 0x00, 0x09, 0x74, 0x65, 0x73, 0x74, 0x67, 0x72, 0x6F, 0x75,
                0x70, 0x17, 0xB7, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0xC8, 0x00, 0x02, 0x2A, 0x18, 0x00,
                0x07, 0x47, 0x65, 0x6E, 0x65, 0x72, 0x61, 0x6C, 0x23, 0x8C, 0x00, 0x00, 0x00, 0x01, 0x00, 0x0C,
                0x00, 0xC8, 0x00, 0x08, 0x26, 0x9A, 0x08, 0x80, 0x12, 0xA1, 0x05, 0x83
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1308>(f);

            Assert.Inconclusive("Verify that Snac1308 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1309DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x7C, 0xC2, 0x00, 0x27, 0x00, 0x13, 0x00, 0x09, 0x00, 0x00, 0x00, 0x07, 0x00, 0x09,
                0x00, 0x07, 0x42, 0x75, 0x64, 0x64, 0x69, 0x65, 0x73, 0x72, 0xCD, 0x00, 0x00, 0x00, 0x01, 0x00,
                0x0C, 0x00, 0xC8, 0x00, 0x08, 0x0F, 0x63, 0x78, 0x2A, 0x63, 0x6F, 0x5A, 0x9B
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1309>(f);

            Assert.Inconclusive("Verify that Snac1309 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac130ADeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x6C, 0x65, 0x00, 0x1D, 0x00, 0x13, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x83,
                0x00, 0x09, 0x31, 0x33, 0x38, 0x37, 0x38, 0x39, 0x34, 0x39, 0x30, 0x56, 0x71, 0x48, 0x82, 0x00,
                0x00, 0x00, 0x00
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac130A>(f);

            Assert.Inconclusive("Verify that Snac130A was deserialized correctly.");
        }

        [TestMethod]
        public void Snac130EDeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x92, 0x34, 0x00, 0x0C, 0x00, 0x13, 0x00, 0x0E, 0x80, 0x00, 0x00, 0x04, 0x00, 0x08,
                0x00, 0x00
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac130E>(f);

            Assert.Inconclusive("Verify that Snac130E was deserialized correctly.");
        }

        [TestMethod]
        public void Snac130FDeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x38, 0xC5, 0x00, 0x10, 0x00, 0x13, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x05,
                0x3D, 0xE7, 0x48, 0x17, 0x00, 0xBB
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac130F>(f);

            Assert.Inconclusive("Verify that Snac130F was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1311DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x22, 0x96, 0x00, 0x0A, 0x00, 0x13, 0x00, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1311>(f);

            Assert.Inconclusive("Verify that Snac1311 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1312DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x22, 0x96, 0x00, 0x0A, 0x00, 0x13, 0x00, 0x12, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1312>(f);

            Assert.Inconclusive("Verify that Snac1312 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1314DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x1D, 0x56, 0x00, 0x1A, 0x00, 0x13, 0x00, 0x14, 0x00, 0x00, 0x00, 0x01, 0x00, 0x14,
                0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x35, 0x00, 0x04, 0x73, 0x75, 0x72, 0x65, 0x00, 0x00
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1314>(f);

            Assert.Inconclusive("Verify that Snac1314 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1315DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x1D, 0x56, 0x00, 0x1A, 0x00, 0x13, 0x00, 0x15, 0x00, 0x00, 0x99, 0xD0, 0x07, 0x62,
                0x07, 0x34, 0x36, 0x37, 0x38, 0x38, 0x31, 0x32, 0x00, 0x04, 0x73, 0x75, 0x72, 0x65, 0x00, 0x00
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1315>(f);

            Assert.Inconclusive("Verify that Snac1315 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1316DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x3D, 0x67, 0x00, 0x12, 0x00, 0x13, 0x00, 0x16, 0x00, 0x00, 0x00, 0x01, 0x00, 0x1C,
                0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x35,
                0x95
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1316>(f);

            Assert.Inconclusive("Verify that Snac1316 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1318DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x2C, 0x6A, 0x00, 0x1C, 0x00, 0x13, 0x00, 0x18, 0x00, 0x00, 0x00, 0x01, 0x00, 0x18,
                0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x36, 0x00, 0x06, 0x70, 0x6C, 0x65, 0x61, 0x73, 0x65,
                0x00, 0x00
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1318>(f);

            Assert.Inconclusive("Verify that Snac1318 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1319DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x2C, 0x3A, 0x00, 0x1C, 0x00, 0x13, 0x00, 0x19, 0x00, 0x00, 0x00, 0x01, 0x00, 0x19,
                0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x35, 0x00, 0x06, 0x70, 0x6C, 0x65, 0x61, 0x73, 0x65,
                0x00, 0x00
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1319>(f);

            Assert.Inconclusive("Verify that Snac1319 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac131ADeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x3A, 0x6A, 0x00, 0x1A, 0x00, 0x13, 0x00, 0x1A, 0x00, 0x00, 0x00, 0x01, 0x00, 0x1A,
                0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x36, 0x00, 0x00, 0x05, 0x73, 0x6F, 0x72, 0x72, 0x79
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac131A>(f);

            Assert.Inconclusive("Verify that Snac131A was deserialized correctly.");
        }

        [TestMethod]
        public void Snac131BDeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x3C, 0x6A, 0x00, 0x1A, 0x00, 0x13, 0x00, 0x1B, 0x00, 0x00, 0x00, 0x01, 0x00, 0x1B,
                0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x35, 0x00, 0x00, 0x05, 0x73, 0x6F, 0x72, 0x72, 0x79
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac131B>(f);

            Assert.Inconclusive("Verify that Snac131B was deserialized correctly.");
        }

        [TestMethod]
        public void Snac131CDeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x3D, 0x67, 0x00, 0x12, 0x00, 0x13, 0x00, 0x1C, 0x00, 0x00, 0x00, 0x01, 0x00, 0x1C,
                0x07, 0x36, 0x32, 0x31, 0x38, 0x38, 0x39, 0x35
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac131C>(f);

            Assert.Inconclusive("Verify that Snac131C was deserialized correctly.");
        }
    }
}