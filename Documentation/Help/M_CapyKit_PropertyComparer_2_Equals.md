# Equals(T, T) Method


Determines whether the specified properties are equal.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public bool Equals(
	T x,
	T y
)
```
**VB**
``` VB
Public Function Equals ( 
	x As T,
	y As T
) As Boolean
```
**C++**
``` C++
public:
virtual bool Equals(
	T x, 
	T y
) sealed
```
**F#**
``` F#
abstract Equals : 
        x : 'T * 
        y : 'T -> bool 
override Equals : 
        x : 'T * 
        y : 'T -> bool 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_PropertyComparer_2">T</a></dt><dd>The first object of type <em>T</em> to compare.</dd><dt>  <a href="T_CapyKit_PropertyComparer_2">T</a></dt><dd>The second object of type <em>T</em> to compare.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if the specified objects are equal; otherwise, false.

#### Implements
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1.equals" target="_blank" rel="noopener noreferrer">IEqualityComparer(T).Equals(T, T)</a>  


## See Also


#### Reference
<a href="T_CapyKit_PropertyComparer_2">PropertyComparer(T, U) Class</a>  
<a href="Overload_CapyKit_PropertyComparer_2_Equals">Equals Overload</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
