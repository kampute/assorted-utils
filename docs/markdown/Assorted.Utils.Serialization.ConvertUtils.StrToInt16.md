﻿# ConvertUtils.StrToInt16(string) Method

> Namespace: [Assorted.Utils.Serialization](_toc.Assorted.Utils.md#Assorted.Utils.Serialization%20Namespace)\
> Assembly: [Assorted.Utils](_toc.Assorted.Utils.md) (Assorted.Utils.dll) version 1.0.0.0

Converts the specified standard string representation of an integer number to its [`System.Int16`](https://docs.microsoft.com/en-us/dotnet/api/system.int16) equivalent. The leading and trailing white spaces are ignored.

## Syntax

```csharp
public static short? StrToInt16(string value)
```

### Parameters

`value`: [string](https://docs.microsoft.com/en-us/dotnet/api/system.string)\
The string representation of an integer value.

### Return Value

[short?](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)\
A 16-bit signed integer number whose value is represented by `value` if the operation succeeds; otherwise, `null`.

## See Also

- [Assorted.Utils.Serialization Namespace](_toc.Assorted.Utils.md#Assorted.Utils.Serialization%20Namespace)
- [ConvertUtils Class](Assorted.Utils.Serialization.ConvertUtils.md)

---

_This document is generated by [DG](https://github.com/Khojasteh/dg)._