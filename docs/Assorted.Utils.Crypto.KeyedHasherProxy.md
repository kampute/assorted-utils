﻿# KeyedHasherProxy Class

> Namespace: [Assorted.Utils.Crypto](index.md#assortedutilscrypto-namespace)\
> Assembly: [Assorted.Utils](index.md) (Assorted.Utils.dll) version 1.0.0.0\
> Inheritance: [object](https://docs.microsoft.com/en-us/dotnet/api/system.object) `→` [KeyedHasher](Assorted.Utils.Crypto.KeyedHasher.md) `→` KeyedHasherProxy

Wraps a .NET keyed-hash (HMAC) algorithm.

## Syntax

```csharp
public class KeyedHasherProxy : KeyedHasher
```

## Constructors

Constructor | Description
--- | ---
[KeyedHasherProxy(Func\<KeyedHashAlgorithm>)](Assorted.Utils.Crypto.KeyedHasherProxy.-ctor.md) | Initializes a new instances of [`KeyedHasherProxy`](Assorted.Utils.Crypto.KeyedHasherProxy.md) class with the specified algorithm factory.

## Properties

Property | Description
--- | ---
[Size](Assorted.Utils.Crypto.KeyedHasherProxy.Size.md) | Gets the size, in bits, of the computed hash code.

## Methods

Method | Description
--- | ---
[Compute(Byte[], Byte[])](Assorted.Utils.Crypto.KeyedHasherProxy.Compute.md#computebyte-byte) | Returns the keyed-hash code of a specified array of bytes for the given secret key.
[Compute(Byte[], Stream)](Assorted.Utils.Crypto.KeyedHasherProxy.Compute.md#computebyte-stream) | Returns the keyed-hash code of content of a specified stream for the given secret key.

## Thread Safety

Any public member of this type, either static or instance, is thread\-safe.

## See Also

- [Assorted.Utils.Crypto Namespace](index.md#assortedutilscrypto-namespace)

---

_This document is generated by [DG](https://github.com/Khojasteh/dg)._
