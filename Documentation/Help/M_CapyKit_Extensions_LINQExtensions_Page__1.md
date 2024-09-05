# Page&lt;T&gt;(IEnumerable&lt;T&gt;, Int32, Int32) Method


Get a page of items from a collection, skipping *pageNumber* pages of *pageSize* items per page.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions.md">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static IEnumerable<T> Page<T>(
	this IEnumerable<T> source,
	int pageNumber,
	int pageSize
)

```
**F#**
``` F#
[<ExtensionAttribute>]
static member Page : 
        source : IEnumerable<'T> * 
        pageNumber : int * 
        pageSize : int -> IEnumerable<'T> 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T)</dt><dd>The source to act on.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a></dt><dd>The page number to retrieve.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a></dt><dd>Number of items per page.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T)  
An enumerator that allows foreach to be used to process page in this collection.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Remarks
This method uses natural numbering starting at page 1.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception" target="_blank" rel="noopener noreferrer">ArgumentOutOfRangeException</a></td>
<td>Thrown when <em>pageNumber</em> is less than <code>1</code> or if <em>pageSize</em> is less than <code>1</code>.</td></tr>
</table>

## See Also


#### Reference
<a href="T_CapyKit_Extensions_LINQExtensions.md">LINQExtensions Class</a>  
<a href="Overload_CapyKit_Extensions_LINQExtensions_Page.md">Page Overload</a>  
<a href="N_CapyKit_Extensions.md">CapyKit.Extensions Namespace</a>  
