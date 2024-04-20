# GetPrettyName Method


An <a href="https://learn.microsoft.com/dotnet/api/system.enum" target="_blank" rel="noopener noreferrer">Enum</a> extension method that gets a human readable name.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static string GetPrettyName(
	this Enum enumeration
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function GetPrettyName ( 
	enumeration As Enum
) As String
```
**C++**
``` C++
public:
[ExtensionAttribute]
static String^ GetPrettyName(
	Enum^ enumeration
)
```
**F#**
``` F#
[<ExtensionAttribute>]
static member GetPrettyName : 
        enumeration : Enum -> string 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.enum" target="_blank" rel="noopener noreferrer">Enum</a></dt><dd>The enumeration to act on.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
The human readable name of the enumeration.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.enum" target="_blank" rel="noopener noreferrer">Enum</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_EnumerationExtensions">EnumerationExtensions Class</a>  
<a href="N_CapyKit_Extensions">CapyKit.Extensions Namespace</a>  
