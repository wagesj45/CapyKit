# Filter&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T, Boolean&gt;) Method


Filters out items matching a *predicate* from the collection.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions.md">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static IEnumerable<T> Filter<T>(
	this IEnumerable<T> source,
	Func<T, bool> predicate
)

```
**F#**
``` F#
[<ExtensionAttribute>]
static member Filter : 
        source : IEnumerable<'T> * 
        predicate : Func<'T, bool> -> IEnumerable<'T> 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T)</dt><dd>The source to act on.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(T, <a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>)</dt><dd>The predicate.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T)  
An enumerator that allows foreach to be used to process remove in this collection.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_LINQExtensions.md">LINQExtensions Class</a>  
<a href="Overload_CapyKit_Extensions_LINQExtensions_Filter.md">Filter Overload</a>  
<a href="N_CapyKit_Extensions.md">CapyKit.Extensions Namespace</a>  
