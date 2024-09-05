# LINQExtensions Class


Provides static extension methods for performing common LINQ operations on <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable(T)</a> and <a href="https://learn.microsoft.com/dotnet/api/system.linq.iqueryable-1" target="_blank" rel="noopener noreferrer">IQueryable(T)</a> collections.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions.md">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static class LINQExtensions
```
**F#**
``` F#
[<AbstractClassAttribute>]
[<SealedAttribute>]
[<ExtensionAttribute>]
type LINQExtensions = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  LINQExtensions</td></tr>
</table>



## Methods
<table>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Distinct__2.md">Distinct(T, U)</a></td>
<td>Enumerates distinct items in this collection as defined by the key <em>property</em>.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Filter__1.md">Filter(T)(IEnumerable(T), Func(T, Boolean))</a></td>
<td>Filters out items matching a <em>predicate</em> from the collection.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Filter__1_1.md">Filter(T)(IQueryable(T), Expression(Func(T, Boolean)))</a></td>
<td>Filters out items matching a <em>predicate</em> from the collection.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_LeftOuterJoin__4_2.md">LeftOuterJoin(T, U, TKey, R)(IQueryable(T), IQueryable(U), Expression(Func(T, TKey)), Expression(Func(U, TKey)), Expression(Func(T, IEnumerable(U), R)))</a></td>
<td>An IQueryable&lt;T&gt; extension method that left outer join.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_LeftOuterJoin__4.md">LeftOuterJoin(T, U, TKey, R)(IEnumerable(T), IEnumerable(U), Func(T, TKey), Func(U, TKey), Func(T, IEnumerable(U), R), Func(T, U))</a></td>
<td>An IEnumable&lt;T&gt; extension method that left outer join.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_LeftOuterJoin__4_1.md">LeftOuterJoin(T, U, TKey, R)(IQueryable(T), IQueryable(U), Expression(Func(T, TKey)), Expression(Func(U, TKey)), Func(T, IEnumerable(U), R), Func(T, U))</a></td>
<td>An IQueryable&lt;T&gt; extension method that left outer join.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Page__1.md">Page(T)(IEnumerable(T), Int32, Int32)</a></td>
<td>Get a page of items from a collection, skipping <em>pageNumber</em> pages of <em>pageSize</em> items per page.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Page__1_1.md">Page(T)(IQueryable(T), Int32, Int32)</a></td>
<td>Get a page of items from a collection, skipping <em>pageNumber</em> pages of <em>pageSize</em> items per page.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_PageCount__1.md">PageCount(T)(IEnumerable(T), Int32)</a></td>
<td>The number of pages of <em>pageSize</em> size in the given collection.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_PageCount__1_1.md">PageCount(T)(IQueryable(T), Int32)</a></td>
<td>The number of pages of <em>pageSize</em> size in the given collection.</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit_Extensions.md">CapyKit.Extensions Namespace</a>  
