# LeftOuterJoin&lt;T, U, TKey, R&gt;(IEnumerable&lt;T&gt;, IEnumerable&lt;U&gt;, Func&lt;T, TKey&gt;, Func&lt;U, TKey&gt;, Func&lt;T, IEnumerable&lt;U&gt;, R&gt;, Func&lt;T, U&gt;) Method


An IEnumable&lt;T&gt; extension method that left outer join.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions.md">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

**C#**
``` C#
public static IEnumerable<R> LeftOuterJoin<T, U, TKey, R>(
	this IEnumerable<T> source,
	IEnumerable<U> inner,
	Func<T, TKey> outerSelector,
	Func<U, TKey> innerSelector,
	Func<T, IEnumerable<U>, R> resultSelector,
	Func<T, U> defaultGenerator = null
)

```
**F#**
``` F#
[<ExtensionAttribute>]
static member LeftOuterJoin : 
        source : IEnumerable<'T> * 
        inner : IEnumerable<'U> * 
        outerSelector : Func<'T, 'TKey> * 
        innerSelector : Func<'U, 'TKey> * 
        resultSelector : Func<'T, IEnumerable<'U>, 'R> * 
        ?defaultGenerator : Func<'T, 'U> 
(* Defaults:
        let _defaultGenerator = defaultArg defaultGenerator null
*)
-> IEnumerable<'R> 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T)</dt><dd>The source to act on.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(U)</dt><dd>The inner.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(T, TKey)</dt><dd>The outer selector.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(U, TKey)</dt><dd>The inner selector.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-3" target="_blank" rel="noopener noreferrer">Func</a>(T, <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(U), R)</dt><dd>The result selector.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(T, U)  (Optional)</dt><dd>(Optional) The default generator.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd><dt /><dd>Generic type parameter.</dd><dt /><dd>Type of the key.</dd><dt /><dd>Type of the r.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(R)  
An enumerator that allows foreach to be used to process left outter join in this collection.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_LINQExtensions.md">LINQExtensions Class</a>  
<a href="Overload_CapyKit_Extensions_LINQExtensions_LeftOuterJoin.md">LeftOuterJoin Overload</a>  
<a href="N_CapyKit_Extensions.md">CapyKit.Extensions Namespace</a>  
