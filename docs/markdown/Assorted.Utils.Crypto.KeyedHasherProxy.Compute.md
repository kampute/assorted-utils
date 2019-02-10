﻿# KeyedHasherProxy.Compute Method

> Namespace: [Assorted.Utils.Crypto](_toc.Assorted.Utils.md#Assorted.Utils.Crypto%20Namespace)\
> Assembly: [Assorted.Utils](_toc.Assorted.Utils.md) (Assorted.Utils.dll) version 1.0.0.0

Overload | Description
--- | ---
[Compute(Byte[], Byte[])](Assorted.Utils.Crypto.KeyedHasherProxy.Compute.md#Compute%28Byte%5B%5D%2C%20Byte%5B%5D%29) | Returns the keyed-hash code of a specified array of bytes for the given secret key.
[Compute(Byte[], Stream)](Assorted.Utils.Crypto.KeyedHasherProxy.Compute.md#Compute%28Byte%5B%5D%2C%20Stream%29) | Returns the keyed-hash code of content of a specified stream for the given secret key.

## Compute(Byte[], Byte[])

Returns the keyed-hash code of a specified array of bytes for the given secret key.

### Syntax

```csharp
public override Byte[] Compute(Byte[] key, Byte[] bytes)
```

#### Parameters

`key`: [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)\
The secret key as an array of bytes.

`bytes`: [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)\
An array of bytes to calculate its keyed-hash code.

#### Return Value

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)\
The keyed-hash code of the specified `bytes` as an array of bytes.

### Exceptions

Exception | Description
--- | ---
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception) | `key` or `bytes` is `null`.

### See Also

- [Assorted.Utils.Crypto Namespace](_toc.Assorted.Utils.md#Assorted.Utils.Crypto%20Namespace)
- [KeyedHasherProxy Class](Assorted.Utils.Crypto.KeyedHasherProxy.md)

## Compute(Byte[], Stream)

Returns the keyed-hash code of content of a specified stream for the given secret key.

### Syntax

```csharp
public override Byte[] Compute(Byte[] key, Stream stream)
```

#### Parameters

`key`: [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)\
The secret key for encryption.

`stream`: [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\
A [`System.IO.Stream`](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream) object to calculate the keyed-hash code of its content.

#### Return Value

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)\
The keyed-hash code of content of the specified `stream` as an array of bytes.

### Exceptions

Exception | Description
--- | ---
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception) | `key` or `stream` is `null`.

### See Also

- [Assorted.Utils.Crypto Namespace](_toc.Assorted.Utils.md#Assorted.Utils.Crypto%20Namespace)
- [KeyedHasherProxy Class](Assorted.Utils.Crypto.KeyedHasherProxy.md)

---

_This document is generated by [DG](https://github.com/Khojasteh/dg)._