# Distinct&lt;T, U&gt; Method


Enumerates distinct items in this collection as defined by the key *property*.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static IEnumerable<T> Distinct<T, U>(
	this IEnumerable<T> items,
	Func<T, U> property
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function Distinct(Of T, U) ( 
	items As IEnumerable(Of T),
	property As Func(Of T, U)
) As IEnumerable(Of T)
```
**C++**
``` C++
public:
[ExtensionAttribute]
generic<typename T, typename U>
static IEnumerable<T>^ Distinct(
	IEnumerable<T>^ items, 
	Func<T, U>^ property
)
```
**F#**
``` F#
[<ExtensionAttribute>]
static member Distinct : 
        items : IEnumerable<'T> * 
        property : Func<'T, 'U> -> IEnumerable<'T> 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T)</dt><dd>The items to act on.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(T, U)</dt><dd>The property.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter of the parent object.</dd><dt /><dd>Generic type parameter property value.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T)  
An enumerator that allows foreach to be used to process distinct items in this collection.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(T). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_LINQExtensions">LINQExtensions Class</a>  
<a href="N_CapyKit_Extensions">CapyKit.Extensions Namespace</a>  
