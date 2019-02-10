﻿using NUnit.Framework;
using System.IO;

namespace Assorted.Utils.Serialization.Tests
{
    [TestFixture]
    [TestOf(typeof(BinarySerializer))]
    public class BinarySerializerTests
    {
        [Test]
        public void Serialization_To_And_From_String()
        {
            var origin = TestGraph.CreateSample(4);

            var serialized = Serializer.Binary.Serialize(origin);
            Assert.That(serialized, Is.Not.Null);

            var duplicate = Serializer.Binary.Deserialize<TestGraph>(serialized);
            Assert.That(origin, Is.EqualTo(duplicate));
        }

        [Test]
        public void Serialization_To_And_From_Stream()
        {
            var origin = TestGraph.CreateSample(4);

            using (var stream = new MemoryStream())
            {
                Serializer.Binary.Serialize(origin, stream);
                Assert.That(stream.Length, Is.Not.Zero);

                stream.Position = 0;
                var duplicate = Serializer.Binary.Deserialize<TestGraph>(stream);
                Assert.That(origin, Is.EqualTo(duplicate));
            }
        }
    }
}