# LeftOuterJoin&lt;T, U, TKey, R&gt;(IQueryable&lt;T&gt;, IQueryable&lt;U&gt;, Expression&lt;Func&lt;T, TKey&gt;&gt;, Expression&lt;Func&lt;U, TKey&gt;&gt;, Func&lt;T, IEnumerable&lt;U&gt;, R&gt;, Func&lt;T, U&gt;) Method


An IQueryable&lt;T&gt; extension method that left outer join.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static IQueryable<R> LeftOuterJoin<T, U, TKey, R>(
	this IQueryable<T> source,
	IQueryable<U> inner,
	Expression<Func<T, TKey>> outerSelector,
	Expression<Func<U, TKey>> innerSelector,
	Func<T, IEnumerable<U>, R> resultSelector,
	Func<T, U> defaultGenerator = null
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function LeftOuterJoin(Of T, U, TKey, R) ( 
	source As IQueryable(Of T),
	inner As IQueryable(Of U),
	outerSelector As Expression(Of Func(Of T, TKey)),
	innerSelector As Expression(Of Func(Of U, TKey)),
	resultSelector As Func(Of T, IEnumerable(Of U), R),
	Optional defaultGenerator As Func(Of T, U) = Nothing
) As IQueryable(Of R)
```
**C++**
``` C++
public:
[ExtensionAttribute]
generic<typename T, typename U, typename TKey, typename R>
static IQueryable<R>^ LeftOuterJoin(
	IQueryable<T>^ source, 
	IQueryable<U>^ inner, 
	Expression<Func<T, TKey>^>^ outerSelector, 
	Expression<Func<U, TKey>^>^ innerSelector, 
	Func<T, IEnumerable<U>^, R>^ resultSelector, 
	Func<T, U>^ defaultGenerator = nullptr
)
```
**F#**
``` F#
[<ExtensionAttribute>]
static member LeftOuterJoin : 
        source : IQueryable<'T> * 
        inner : IQueryable<'U> * 
        outerSelector : Expression<Func<'T, 'TKey>> * 
        innerSelector : Expression<Func<'U, 'TKey>> * 
        resultSelector : Func<'T, IEnumerable<'U>, 'R> * 
        ?defaultGenerator : Func<'T, 'U> 
(* Defaults:
        let _defaultGenerator = defaultArg defaultGenerator null
*)
-> IQueryable<'R> 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.linq.iqueryable-1" target="_blank" rel="noopener noreferrer">IQueryable</a>(T)</dt><dd>The source to act on.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.linq.iqueryable-1" target="_blank" rel="noopener noreferrer">IQueryable</a>(U)</dt><dd>The inner.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.linq.expressions.expression-1" target="_blank" rel="noopener noreferrer">Expression</a>(<a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(T, TKey))</dt><dd>The outer selector.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.linq.expressions.expression-1" target="_blank" rel="noopener noreferrer">Expression</a>(<a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(U, TKey))</dt><dd>The inner selector.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-3" target="_blank" rel="noopener noreferrer">Func</a>(T, <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(U), R)</dt><dd>The result selector.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(T, U)  (Optional)</dt><dd>(Optional) The default generator.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd><dt /><dd>Generic type parameter.</dd><dt /><dd>Type of the key.</dd><dt /><dd>Type of the r.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.linq.iqueryable-1" target="_blank" rel="noopener noreferrer">IQueryable</a>(R)  
An IQueryable&lt;R&gt;

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.linq.iqueryable-1" target="_blank" rel="noopener noreferrer">IQueryable</a>(T). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_LINQExtensions">LINQExtensions Class</a>  
<a href="Overload_CapyKit_Extensions_LINQExtensions_LeftOuterJoin">LeftOuterJoin Overload</a>  
<a href="N_CapyKit_Extensions">CapyKit.Extensions Namespace</a>  
