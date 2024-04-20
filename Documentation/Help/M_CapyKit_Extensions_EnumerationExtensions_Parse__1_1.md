# Parse&lt;T&gt;(T, String, Boolean) Method


A *T* extension method that parses a string into an enumeration.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static T Parse<T>(
	this T enumeration,
	string value,
	bool ignoreCase
)
where T : Enum

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function Parse(Of T As Enum) ( 
	enumeration As T,
	value As String,
	ignoreCase As Boolean
) As T
```
**C++**
``` C++
public:
[ExtensionAttribute]
generic<typename T>
where T : Enum
static T Parse(
	T enumeration, 
	String^ value, 
	bool ignoreCase
)
```
**F#**
``` F#
[<ExtensionAttribute>]
static member Parse : 
        enumeration : 'T * 
        value : string * 
        ignoreCase : bool -> 'T  when 'T : Enum
```



#### Parameters
<dl><dt>  T</dt><dd>The enumeration to act on.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The string value of the <a href="https://learn.microsoft.com/dotnet/api/system.enum" target="_blank" rel="noopener noreferrer">Enum</a>.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a></dt><dd>True to ignore case.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd></dl>

#### Return Value
T  
A T.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type T. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_EnumerationExtensions">EnumerationExtensions Class</a>  
<a href="Overload_CapyKit_Extensions_EnumerationExtensions_Parse">Parse Overload</a>  
<a href="N_CapyKit_Extensions">CapyKit.Extensions Namespace</a>  
