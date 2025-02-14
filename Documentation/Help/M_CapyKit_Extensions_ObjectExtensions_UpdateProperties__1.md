# UpdateProperties&lt;T&gt;(T, T) Method


An object extension method that updates the properties of a given *target* object with the values from a given *source* object.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions.md">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public static void UpdateProperties<T>(
	this T target,
	T source
)

```
**F#**
``` F#
[<ExtensionAttribute>]
static member UpdateProperties : 
        target : 'T * 
        source : 'T -> unit 
```



#### Parameters
<dl><dt>  T</dt><dd>The target object to act on.</dd><dt>  T</dt><dd>Source for the new property values.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type T. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_ObjectExtensions.md">ObjectExtensions Class</a>  
<a href="Overload_CapyKit_Extensions_ObjectExtensions_UpdateProperties.md">UpdateProperties Overload</a>  
<a href="N_CapyKit_Extensions.md">CapyKit.Extensions Namespace</a>  
