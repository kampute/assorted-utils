﻿// Copyright (c) 2019 Kambiz Khojasteh
// This file is part of the Assorted.Utils package which is released under the MIT software license.
// See the accompanying file LICENSE.txt or go to http://www.opensource.org/licenses/mit-license.php.

using NUnit.Framework;
using System.IO;

namespace Assorted.Utils.Serialization.Tests
{
    [TestFixture]
    [TestOf(typeof(JsonSerializer))]
    public class JsonSerializerTests
    {
        [Test]
        public void Serialization_To_And_From_String()
        {
            var origin = TestGraph.CreateSample(4);

            var serialized = Serializer.JSON.Serialize(origin);
            Assert.That(serialized, Is.Not.Null);

            var duplicate = Serializer.JSON.Deserialize<TestGraph>(serialized);
            Assert.That(origin, Is.EqualTo(duplicate));
        }

        [Test]
        public void Serialization_To_And_From_Stream()
        {
            var origin = TestGraph.CreateSample(4);

            using (var stream = new MemoryStream())
            {
                Serializer.JSON.Serialize(origin, stream);
                Assert.That(stream.Length, Is.Not.Zero);

                stream.Position = 0;
                var duplicate = Serializer.JSON.Deserialize<TestGraph>(stream);
                Assert.That(origin, Is.EqualTo(duplicate));
            }
        }
    }
}