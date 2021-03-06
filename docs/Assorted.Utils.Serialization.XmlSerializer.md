﻿# XmlSerializer Class

> Namespace: [Assorted.Utils.Serialization](index.md#assortedutilsserialization-namespace)\
> Assembly: [Assorted.Utils](index.md) (Assorted.Utils.dll) version 1.0.0.0\
> Implements: [ISerializer](Assorted.Utils.Serialization.ISerializer.md)\
> Inheritance: [object](https://docs.microsoft.com/en-us/dotnet/api/system.object) `→` XmlSerializer

Serializes and deserializes objects into and from XML documents.

## Syntax

```csharp
public class XmlSerializer : ISerializer
```

## Constructors

Constructor | Description
--- | ---
[XmlSerializer()](Assorted.Utils.Serialization.XmlSerializer.-ctor.md#xmlserializer) | Initializes a new instance of [`XmlSerializer`](Assorted.Utils.Serialization.XmlSerializer.md) class without a name-space.
[XmlSerializer(XmlSerializerNamespaces)](Assorted.Utils.Serialization.XmlSerializer.-ctor.md#xmlserializerxmlserializernamespaces) | Initializes a new instance of [`XmlSerializer`](Assorted.Utils.Serialization.XmlSerializer.md) class with the specified name-spaces.

## Fields

Field | Description
--- | ---
[DefaultNamespaces](Assorted.Utils.Serialization.XmlSerializer.DefaultNamespaces.md) | The default name-space for XML serialization, which is none.

## Properties

Property | Description
--- | ---
[Namespaces](Assorted.Utils.Serialization.XmlSerializer.Namespaces.md) | Gets the name-spaces being used for XML serialization.

## Methods

Method | Description
--- | ---
[Deserialize\<T>(Stream)](Assorted.Utils.Serialization.XmlSerializer.Deserialize.md#deserializetstream) | Deserializes the XML document contained by the specified [`System.IO.Stream`](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream).
[Deserialize\<T>(string)](Assorted.Utils.Serialization.XmlSerializer.Deserialize.md#deserializetstring) | Converts the XML representation of an object to an instance of that object.
[Deserialize\<T>(TextReader)](Assorted.Utils.Serialization.XmlSerializer.Deserialize.md#deserializettextreader) | Deserializes the XML document contained by the specified [`System.IO.TextReader`](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader).
[GetInternalSerializer\<T>()](Assorted.Utils.Serialization.XmlSerializer.GetInternalSerializer.md) | Creates an instance of [`System.Xml.Serialization.XmlSerializer`](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer) class for the specified type.
[Serialize\<T>(T)](Assorted.Utils.Serialization.XmlSerializer.Serialize.md#serializett) | Converts an object to its XML representation.
[Serialize\<T>(T, Stream)](Assorted.Utils.Serialization.XmlSerializer.Serialize.md#serializett-stream) | Serializes a given object and writes the XML document into the specified [`System.IO.Stream`](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream).
[Serialize\<T>(TextWriter, T)](Assorted.Utils.Serialization.XmlSerializer.Serialize.md#serializettextwriter-t) | Serializes a given object and writes the XML document into the specified [`System.IO.TextWriter`](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter).

## Thread Safety

Any public member of this type, either static or instance, is thread\-safe.

## See Also

- [Assorted.Utils.Serialization Namespace](index.md#assortedutilsserialization-namespace)

---

_This document is generated by [DG](https://github.com/Khojasteh/dg)._
