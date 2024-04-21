# FillPoolItemCollection(Int32, Func&lt;T&gt;) Method


Initializes the pool with the specified number of items using the specified constructor selector.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
private void FillPoolItemCollection(
	int poolSize,
	Func<T> constructorSelector
)
```
**F#**
``` F#
private member FillPoolItemCollection : 
        poolSize : int * 
        constructorSelector : Func<'T> -> unit 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a></dt><dd>The size of the pool.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-1" target="_blank" rel="noopener noreferrer">Func</a>(<a href="T_CapyKit_Pool_1.md">T</a>)</dt><dd>The constructor selector.</dd></dl>

## See Also


#### Reference
<a href="T_CapyKit_Pool_1.md">Pool(T) Class</a>  
<a href="Overload_CapyKit_Pool_1_FillPoolItemCollection.md">FillPoolItemCollection Overload</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
