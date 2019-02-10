﻿# Recurrent.Weekly Method

> Namespace: [Assorted.Utils.Dates](_toc.Assorted.Utils.md#Assorted.Utils.Dates%20Namespace)\
> Assembly: [Assorted.Utils](_toc.Assorted.Utils.md) (Assorted.Utils.dll) version 1.0.0.0

Returns a weekly reoccurring pattern.

Overload | Description
--- | ---
[Weekly(DayOfWeek, int, DayOfWeek)](Assorted.Utils.Dates.Recurrent.Weekly.md#Weekly%28DayOfWeek%2C%20int%2C%20DayOfWeek%29) | Returns a weekly reoccurring pattern when events occur on a specific day of the week.
[Weekly(DaysOfTheWeek, int, DayOfWeek)](Assorted.Utils.Dates.Recurrent.Weekly.md#Weekly%28DaysOfTheWeek%2C%20int%2C%20DayOfWeek%29) | Returns a weekly reoccurring pattern when events occur on the specified days of the week.

## Weekly(DayOfWeek, int, DayOfWeek)

Returns a weekly reoccurring pattern when events occur on a specific day of the week.

### Syntax

```csharp
public static WeeklyPattern Weekly(
    DayOfWeek dayOfWeek, 
    int interval = 1, 
    DayOfWeek firstDayOfWeek = DayOfWeek.Monday
)
```

#### Parameters

`dayOfWeek`: [DayOfWeek](https://docs.microsoft.com/en-us/dotnet/api/system.dayofweek)\
The day of the week when the event occurs.

`interval`: [int](https://docs.microsoft.com/en-us/dotnet/api/system.int32)\
The interval of occurrences in number of weeks.

`firstDayOfWeek`: [DayOfWeek](https://docs.microsoft.com/en-us/dotnet/api/system.dayofweek)\
The first day of the week.

#### Return Value

[WeeklyPattern](Assorted.Utils.Dates.Patterns.WeeklyPattern.md)\
An instance of [`WeeklyPattern`](Assorted.Utils.Dates.Patterns.WeeklyPattern.md) class.

### Exceptions

Exception | Description
--- | ---
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception) | `interval` is less than 1.

### See Also

- [Assorted.Utils.Dates Namespace](_toc.Assorted.Utils.md#Assorted.Utils.Dates%20Namespace)
- [Recurrent Class](Assorted.Utils.Dates.Recurrent.md)

## Weekly(DaysOfTheWeek, int, DayOfWeek)

Returns a weekly reoccurring pattern when events occur on the specified days of the week.

### Syntax

```csharp
public static WeeklyPattern Weekly(
    DaysOfTheWeek daysOfWeek, 
    int interval = 1, 
    DayOfWeek firstDayOfWeek = DayOfWeek.Monday
)
```

#### Parameters

`daysOfWeek`: [DaysOfTheWeek](Assorted.Utils.Dates.DaysOfTheWeek.md)\
The days of the week when the event occurs.

`interval`: [int](https://docs.microsoft.com/en-us/dotnet/api/system.int32)\
The interval of occurrences in number of weeks.

`firstDayOfWeek`: [DayOfWeek](https://docs.microsoft.com/en-us/dotnet/api/system.dayofweek)\
The first day of the week.

#### Return Value

[WeeklyPattern](Assorted.Utils.Dates.Patterns.WeeklyPattern.md)\
An instance of [`WeeklyPattern`](Assorted.Utils.Dates.Patterns.WeeklyPattern.md) class.

### Exceptions

Exception | Description
--- | ---
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception) | `interval` is less than 1.

### See Also

- [Assorted.Utils.Dates Namespace](_toc.Assorted.Utils.md#Assorted.Utils.Dates%20Namespace)
- [Recurrent Class](Assorted.Utils.Dates.Recurrent.md)

---

_This document is generated by [DG](https://github.com/Khojasteh/dg)._