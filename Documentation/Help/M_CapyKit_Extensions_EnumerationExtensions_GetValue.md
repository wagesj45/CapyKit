# GetValue Method


An <a href="https://learn.microsoft.com/dotnet/api/system.enum" target="_blank" rel="noopener noreferrer">Enum</a> extension method that gets an integer value representing the enumation.



## Definition
**Namespace:** <a href="N_CapyKit_Extensions">CapyKit.Extensions</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static int GetValue(
	this Enum enumeration
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function GetValue ( 
	enumeration As Enum
) As Integer
```
**C++**
``` C++
public:
[ExtensionAttribute]
static int GetValue(
	Enum^ enumeration
)
```
**F#**
``` F#
[<ExtensionAttribute>]
static member GetValue : 
        enumeration : Enum -> int 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.enum" target="_blank" rel="noopener noreferrer">Enum</a></dt><dd>The enumeration to act on.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a>  
The integer value of the enumeration.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.enum" target="_blank" rel="noopener noreferrer">Enum</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_CapyKit_Extensions_EnumerationExtensions">EnumerationExtensions Class</a>  
<a href="N_CapyKit_Extensions">CapyKit.Extensions Namespace</a>  
