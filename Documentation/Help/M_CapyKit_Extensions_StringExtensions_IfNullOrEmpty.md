# IfNullOrEmpty Method


Replaces a null or empty string with a specified replacement string.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static string IfNullOrEmpty(
	this string value,
	string replacement
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function IfNullOrEmpty ( 
	value As String,
	replacement As String
) As String
```
**C++**
``` C++
public:
[ExtensionAttribute]
static String^ IfNullOrEmpty(
	String^ value, 
	String^ replacement
)
```
**F#**
``` F#
[<ExtensionAttribute>]
static member IfNullOrEmpty : 
        value : string * 
        replacement : string -> string 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The original string.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The replacement string.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
The original string if not null or empty, otherwise the replacement string.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_StringExtensions">StringExtensions Class</a>  
<a href="N_CapyKit_Extensions">CapyKit.Extensions Namespace</a>  
<a href="https://learn.microsoft.com/dotnet/api/system.string.isnullorempty" target="_blank" rel="noopener noreferrer">IsNullOrEmpty(String)</a>  
