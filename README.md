Numeric
=======

This is a simple class that allows the creation of generic methods implementing numeric calculations.

Note that this has MASSIVE performance drops over using basic types (1-2 orders of magnitude) due to stack allocations when implicitly casting. 
However it is equivalent in performance to [MiscUtil's generic Operator class](http://www.yoda.arachsys.com/csharp/miscutil/usage/genericoperators.html) when used through operators, and significantly faster when using methods directly.

###Example of use:

```C#
public static T LerpMinMax<T>(Numeric<T> input, Numeric<T> inputMin, Numeric<T> inputMax, Numeric<T> outputMin, Numeric<T> outputMax)
{
     if (input <= inputMin)
     {
        return outputMin;
     }
     else if (input >= inputMax)
     {
        return outputMax;
     }
     return outputMin + ((input - inputMin) / (inputMax - inputMin)) * (outputMax - outputMin);
}
```
