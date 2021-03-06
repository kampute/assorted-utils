﻿# DailyPattern Class

> Namespace: [Assorted.Utils.Dates.Patterns](index.md#assortedutilsdatespatterns-namespace)\
> Assembly: [Assorted.Utils](index.md) (Assorted.Utils.dll) version 1.0.0.0\
> Implements: [IRecurrentPattern](Assorted.Utils.Dates.IRecurrentPattern.md), [IEquatable\<DailyPattern>](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\
> Inheritance: [object](https://docs.microsoft.com/en-us/dotnet/api/system.object) `→` DailyPattern

Generates a sequence of [`System.DateTime`](https://docs.microsoft.com/en-us/dotnet/api/system.datetime) values based on a daily reoccurring pattern.

## Syntax

```csharp
public class DailyPattern : IRecurrentPattern, IEquatable<DailyPattern>
```

## Constructors

Constructor | Description
--- | ---
[DailyPattern(int)](Assorted.Utils.Dates.Patterns.DailyPattern.-ctor.md) | Initializes an instance of [`DailyPattern`](Assorted.Utils.Dates.Patterns.DailyPattern.md) class.

## Properties

Property | Description
--- | ---
[Interval](Assorted.Utils.Dates.Patterns.DailyPattern.Interval.md) | Gets the interval of occurrences in number of days.

## Methods

Method | Description
--- | ---
[Equals(DailyPattern)](Assorted.Utils.Dates.Patterns.DailyPattern.Equals.md#equalsdailypattern) | Indicates whether the current instance is equal to another object of type [`DailyPattern`](Assorted.Utils.Dates.Patterns.DailyPattern.md).
[Equals(object)](Assorted.Utils.Dates.Patterns.DailyPattern.Equals.md#equalsobject) | Determines whether this instance and a specified object are equal.
[GetHashCode()](Assorted.Utils.Dates.Patterns.DailyPattern.GetHashCode.md) | Returns the hash code for this instance.
[GetRecurrencesStartingAt(DateTime)](Assorted.Utils.Dates.Patterns.DailyPattern.GetRecurrencesStartingAt.md) | Returns the sequence of recurring dates, starting at a given [`System.DateTime`](https://docs.microsoft.com/en-us/dotnet/api/system.datetime) value.

## Thread Safety

Any public member of this type, either static or instance, is thread\-safe.

## See Also

- [Assorted.Utils.Dates.Patterns Namespace](index.md#assortedutilsdatespatterns-namespace)

---

_This document is generated by [DG](https://github.com/Khojasteh/dg)._
