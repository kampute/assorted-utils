﻿// Copyright (c) 2019 Kambiz Khojasteh
// This file is part of the Assorted.Utils package which is released under the MIT software license.
// See the accompanying file LICENSE.txt or go to http://www.opensource.org/licenses/mit-license.php.

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assorted.Utils.Crypto.Tests
{
    [TestFixture()]
    [TestOf(typeof(ByteConvert))]
    public class ByteConvertTests
    {
        static readonly byte[] AllBytes = Enumerable.Range(0, 256).Select(i => (byte)i).ToArray();
        static readonly string AllBytesAsHex = "000102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f202122232425262728292a2b2c2d2e2f303132333435363738393a3b3c3d3e3f404142434445464748494a4b4c4d4e4f505152535455565758595a5b5c5d5e5f606162636465666768696a6b6c6d6e6f707172737475767778797a7b7c7d7e7f808182838485868788898a8b8c8d8e8f909192939495969798999a9b9c9d9e9fa0a1a2a3a4a5a6a7a8a9aaabacadaeafb0b1b2b3b4b5b6b7b8b9babbbcbdbebfc0c1c2c3c4c5c6c7c8c9cacbcccdcecfd0d1d2d3d4d5d6d7d8d9dadbdcdddedfe0e1e2e3e4e5e6e7e8e9eaebecedeeeff0f1f2f3f4f5f6f7f8f9fafbfcfdfeff";

        static IEnumerable<TestCaseData> ByteToHexTestCases()
        {
            yield return new TestCaseData(Array.Empty<byte>()).Returns(string.Empty);
            yield return new TestCaseData(AllBytes).Returns(AllBytesAsHex);
        }

        static IEnumerable<TestCaseData> HexToByteTestCases()
        {
            yield return new TestCaseData(string.Empty).Returns(Array.Empty<byte>());
            yield return new TestCaseData(AllBytesAsHex.ToLower()).Returns(AllBytes);
            yield return new TestCaseData(AllBytesAsHex.ToUpper()).Returns(AllBytes);
        }

        [TestCaseSource(nameof(ByteToHexTestCases))]
        public string Bytes_To_Hexadecimal_String(byte[] bytes)
        {
            return ByteConvert.ToHex(bytes);
        }

        [TestCaseSource(nameof(HexToByteTestCases))]
        public byte[] Hexadecimal_String_To_Bytes(string hex)
        {
            return ByteConvert.FromHex(hex);
        }

        [Test]
        public void Hexadecimal_String_To_Bytes_InvalidFormat([Values("0", "0X", "X0")] string hex)
        {
            Assert.Throws<FormatException>(() => ByteConvert.FromHex(hex));
        }
    }
}