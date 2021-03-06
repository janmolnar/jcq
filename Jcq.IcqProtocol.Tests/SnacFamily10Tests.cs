﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnacFamily10Tests.cs" company="Jan-Cornelius Molnar">
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
    public class SnacFamily10Tests
    {
        //[TestMethod]
        //public void Snac1001DeserializeTest()
        //{
        //    var data = new byte[]
        //    {
        //        0x2A, 0x02, 0xE1, 0xCA, 0x00, 0x0C, 0x00, 0x10, 0x00, 0x01, 0x00, 0x00, 0x99, 0xD0, 0x07, 0x62, 
        //        0x00, 0x05
        //    };

        //    var f = SerializationTools.DeserializeFlap(data);
        //    var s = SerializationTools.DeserializeSnac<Snac1001>(f);

        //    Assert.Inconclusive("Verify that Snac1001 was deserialized correctly.");
        //}

        [TestMethod]
        public void Snac1002DeserializeTest()
        {
            var data = new byte[]
            {
                0x02,
                0x01,
                0x00, 0x10, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x02,
                0x00, 0x01, 0x01, 0x95, 0x47, 0x49, 0x46, 0x38, 0x39, 0x61, 0x20, 0x00, 0x20, 0x00,
                0x00,
                0x00,
                0x00,
                0x00, 0x00, 0x00,
                0x00, 0x80,
                0x00, 0x60,
                0x00,
                0x40, 0x80, 0x00,
                0x40,
                0x40,
                0x80,
                0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x21,
                0x04, 0x01, 0x00, 0x00, 0x00, 0x00, 0x21,
                0x30, 0x43, 0x72, 0x65, 0x61,
                0x74,
                0x72,
                0x20, 0x50,
                0x79, 0x56, 0x69, 0x65, 0x77,
                0x20, 0x56,
                0x65, 0x72, 0x73, 0x69,
                0x20, 0x33,
                0x32, 0x30, 0x20, 0x62, 0x79, 0x20, 0x50,
                0x20,
                0x79, 0x62, 0x79, 0x74, 0x65, 0x73,
                0x00,
                0x00, 0x00,
                0x00, 0x00, 0x20, 0x00, 0x20, 0x00, 0x00, 0x04,
                0x10,
                0x49,
                0x38,
                0x83,
                0x60,
                0x30,
                0x44,
                0x37, 0x02,
                0x20,
                0x68,
                0x05, 0x72,
                0x47, 0x92,
                0x19,
                0x06,
                0x66, 0x13, 0x12, 0x29, 0x01,
                0x70, 0x90,
                0x83, 0x80,
                0x84,
                0x60,
                0x34,
                0x23, 0x68, 0x85,
                0x49,
                0x74,
                0x40,
                0x71, 0x69,
                0x12,
                0x76, 0x12, 0x78,
                0x84, 0x07,
                0x64, 0x28, 0x67,
                0x30, 0x09,
                0x01, 0x84,
                0x86, 0x01, 0x09, 0x93,
                0x33, 0x66,
                0x39,
                0x08, 0x91,
                0x93,
                0x51,
                0x92,
                0x92,
                0x84,
                0x94, 0x88, 0x59,
                0x94, 0x79, 0x70,
                0x94,
                0x26, 0x97,
                0x99,
                0x54,
                0x49, 0x89,
                0x37,
                0x87,
                0x96,
                0x03, 0x66,
                0x59,
                0x82,
                0x32,
                0x94,
                0x30, 0x03,
                0x21, 0x95, 0x74,
                0x04,
                0x34, 0x57,
                0x83, 0x92, 0x02,
                0x89, 0x25, 0x35,
                0x39, 0x21,
                0x03, 0x10,
                0x16, 0x76, 0x08,
                0x52, 0x88, 0x26, 0x38,
                0x90,
                0x50,
                0x09,
                0x52,
                0x18, 0x99, 0x23, 0x64, 0x85,
                0x20,
                0x10, 0x01, 0x00
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1002>(f);

            Assert.Inconclusive("Verify that Snac1002 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1003DeserializeTest()
        {
            var data = new byte[]
            {
                0x02, 0x98,
                0x00,
                0x00, 0x10, 0x00, 0x03, 0x00, 0x00, 0x00, 0x01, 0x00, 0x02,
                0x00, 0x00, 0x01, 0x01, 0x10,
                0x65, 0x56, 0x88,
                0x92,
                0x62
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1003>(f);

            Assert.Inconclusive("Verify that Snac1003 was deserialized correctly.");
        }

        [TestMethod]
        public void Snac1004DeserializeTest()
        {
            var data = new byte[]
            {
                0x2A, 0x02, 0x08, 0x91, 0x00, 0x2A, 0x00, 0x10, 0x00, 0x04, 0x00, 0x00, 0x00, 0x01, 0x00, 0x04,
                0x0A, 0x54, 0x72, 0x6F, 0x6D, 0x70, 0x65, 0x74, 0x65, 0x4A, 0x43, 0x01, 0x00, 0x01, 0x01, 0x10,
                0xB7, 0x39, 0xD9, 0x69, 0x2B, 0x15, 0x60, 0x36, 0x57, 0xC5, 0xC9, 0xB4, 0x89, 0xC9, 0x13, 0x82
            };

            Flap f = SerializationTools.DeserializeFlap(data);
            var s = SerializationTools.DeserializeSnac<Snac1004>(f);

            Assert.Inconclusive("Verify that Snac1004 was deserialized correctly.");
        }
    }
}