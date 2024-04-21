# Pool&lt;T&gt;(Int32, Func&lt;T&gt;) Constructor


Initializes a new instance of the <a href="T_CapyKit_Pool_1">Pool(T)</a> class with the specified pool size and constructor selector.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public Pool(
	int poolSize,
	Func<T> constructorSelector
)
```
**F#**
``` F#
new : 
        poolSize : int * 
        constructorSelector : Func<'T> -> Pool
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a></dt><dd>The size of the pool.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-1" target="_blank" rel="noopener noreferrer">Func</a>(<a href="T_CapyKit_Pool_1">T</a>)</dt><dd>The constructor selector used to create new instances of <em>T</em>.</dd></dl>

## See Also


#### Reference
<a href="T_CapyKit_Pool_1">Pool(T) Class</a>  
<a href="Overload_CapyKit_Pool_1__ctor">Pool(T) Overload</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
