﻿# ConvertUtils.StrToDate(string) Method

> Namespace: [Assorted.Utils.Serialization](index.md#assortedutilsserialization-namespace)\
> Assembly: [Assorted.Utils](index.md) (Assorted.Utils.dll) version 1.0.0.0

Converts the specified standard string representation of a date to its [`System.DateTime`](https://docs.microsoft.com/en-us/dotnet/api/system.datetime) equivalent. The leading and trailing white spaces are ignored.

## Syntax

```csharp
public static DateTime? StrToDate(string value)
```

### Parameters

`value`: [string](https://docs.microsoft.com/en-us/dotnet/api/system.string)\
The string representation of a date in `"yyyy'-'MM'-'dd"` format.

### Return Value

[DateTime?](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)\
A [`System.DateTime`](https://docs.microsoft.com/en-us/dotnet/api/system.datetime) whose value is represented by `value` if the operation succeeds; otherwise, `null`.

## See Also

- [Assorted.Utils.Serialization Namespace](index.md#assortedutilsserialization-namespace)
- [ConvertUtils Class](Assorted.Utils.Serialization.ConvertUtils.md)

---

_This document is generated by [DG](https://github.com/Khojasteh/dg)._
