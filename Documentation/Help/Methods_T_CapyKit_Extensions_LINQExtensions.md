# LINQExtensions Methods




## Methods
<table>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Distinct__2">Distinct(T, U)</a></td>
<td>Enumerates distinct items in this collection as defined by the key <em>property</em>.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Filter__1">Filter(T)(IEnumerable(T), Func(T, Boolean))</a></td>
<td>Filters out items matching a <em>predicate</em> from the collection.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Filter__1_1">Filter(T)(IQueryable(T), Expression(Func(T, Boolean)))</a></td>
<td>Filters out items matching a <em>predicate</em> from the collection.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_LeftOuterJoin__4">LeftOuterJoin(T, U, TKey, R)(IEnumerable(T), IEnumerable(U), Func(T, TKey), Func(U, TKey), Func(T, IEnumerable(U), R), Func(T, U))</a></td>
<td>An IEnumable&lt;T&gt; extension method that left outer join.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_LeftOuterJoin__4_1">LeftOuterJoin(T, U, TKey, R)(IQueryable(T), IQueryable(U), Expression(Func(T, TKey)), Expression(Func(U, TKey)), Func(T, IEnumerable(U), R), Func(T, U))</a></td>
<td>An IQueryable&lt;T&gt; extension method that left outer join.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Page__1">Page(T)(IEnumerable(T), Int32, Int32)</a></td>
<td>Get a page of items from a collection, skipping <em>pageNumber</em> pages of <em>pageSize</em> items per page.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_Page__1_1">Page(T)(IQueryable(T), Int32, Int32)</a></td>
<td>Get a page of items from a collection, skipping <em>pageNumber</em> pages of <em>pageSize</em> items per page.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_PageCount__1">PageCount(T)(IEnumerable(T), Int32)</a></td>
<td>The number of pages of <em>pageSize</em> size in the given collection.</td></tr>
<tr>
<td><a href="M_CapyKit_Extensions_LINQExtensions_PageCount__1_1">PageCount(T)(IQueryable(T), Int32)</a></td>
<td>The number of pages of <em>pageSize</em> size in the given collection.</td></tr>
</table>

## See Also


#### Reference
<a href="T_CapyKit_Extensions_LINQExtensions">LINQExtensions Class</a>  
<a href="N_CapyKit_Extensions">CapyKit.Extensions Namespace</a>  
