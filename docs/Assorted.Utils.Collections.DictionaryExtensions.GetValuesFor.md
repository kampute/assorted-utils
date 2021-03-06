﻿# DictionaryExtensions.GetValuesFor Method

> Namespace: [Assorted.Utils.Collections](index.md#assortedutilscollections-namespace)\
> Assembly: [Assorted.Utils](index.md) (Assorted.Utils.dll) version 1.0.0.0

Returns values of the source dictionary with the specified keys.

Overload | Description
--- | ---
[GetValuesFor\<TKey, TValue>(this IReadOnlyDictionary\<TKey, TValue>, IEnumerable\<TKey>)](Assorted.Utils.Collections.DictionaryExtensions.GetValuesFor.md#getvaluesfortkey-tvaluethis-ireadonlydictionarytkey-tvalue-ienumerabletkey) | Returns values of the source dictionary with the specified keys. The missing keys are ignored.
[GetValuesFor\<TKey, TValue>(this IReadOnlyDictionary\<TKey, TValue>, IEnumerable\<TKey>, TValue)](Assorted.Utils.Collections.DictionaryExtensions.GetValuesFor.md#getvaluesfortkey-tvaluethis-ireadonlydictionarytkey-tvalue-ienumerabletkey-tvalue) | Returns values of the source dictionary with the specified keys. Returns a specific value for any missing key in the dictionary.

## GetValuesFor\<TKey, TValue>(this IReadOnlyDictionary\<TKey, TValue>, IEnumerable\<TKey>)

Returns values of the source dictionary with the specified keys. The missing keys are ignored.

### Syntax

```csharp
public static IEnumerable<TValue> GetValuesFor<TKey, TValue>(
    this IReadOnlyDictionary<TKey, TValue> source, 
    IEnumerable<TKey> keys
)
```

#### Type Parameters

`TKey`\
The type of keys in the dictionary.

`TValue`\
The type of values in the dictionary.

#### Parameters

`source`: [IReadOnlyDictionary\<TKey, TValue>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)\
The source dictionary.

`keys`: [IEnumerable\<TKey>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\
The sequence of keys to locate.

#### Return Value

[IEnumerable\<TValue>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\
A [`System.Collections.Generic.IEnumerable<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1) that contains the values associated with the specified `keys`. The returned sequence does not contain value for the keys that are not found.

### Exceptions

Exception | Description
--- | ---
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception) | `source` or `keys` is `null`.

### Remarks

This method is implemented by using deferred execution. The immediate return value is an object that stores all the information that is required to perform the action.

### See Also

- [Assorted.Utils.Collections Namespace](index.md#assortedutilscollections-namespace)
- [DictionaryExtensions Class](Assorted.Utils.Collections.DictionaryExtensions.md)

## GetValuesFor\<TKey, TValue>(this IReadOnlyDictionary\<TKey, TValue>, IEnumerable\<TKey>, TValue)

Returns values of the source dictionary with the specified keys. Returns a specific value for any missing key in the dictionary.

### Syntax

```csharp
public static IEnumerable<TValue> GetValuesFor<TKey, TValue>(
    this IReadOnlyDictionary<TKey, TValue> source, 
    IEnumerable<TKey> keys, 
    TValue defaultValue
)
```

#### Type Parameters

`TKey`\
The type of keys in the dictionary.

`TValue`\
The type of values in the dictionary.

#### Parameters

`source`: [IReadOnlyDictionary\<TKey, TValue>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)\
The source dictionary.

`keys`: [IEnumerable\<TKey>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\
The sequence of keys to locate.

`defaultValue`: _TValue_\
For any key that is not found, this value will be returned.

#### Return Value

[IEnumerable\<TValue>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\
A [`System.Collections.Generic.IEnumerable<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1) that contains the values associated with the specified `keys`.

### Exceptions

Exception | Description
--- | ---
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception) | `source` or `keys` is `null`.

### Remarks

This method is implemented by using deferred execution. The immediate return value is an object that stores all the information that is required to perform the action.

### See Also

- [Assorted.Utils.Collections Namespace](index.md#assortedutilscollections-namespace)
- [DictionaryExtensions Class](Assorted.Utils.Collections.DictionaryExtensions.md)

---

_This document is generated by [DG](https://github.com/Khojasteh/dg)._
