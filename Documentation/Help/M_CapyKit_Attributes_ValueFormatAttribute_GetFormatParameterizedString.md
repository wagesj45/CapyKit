# GetFormatParameterizedString Method


Gets a parameterized formatted string for the specified index.



## Definition
**Namespace:** <a href="N_CapyKit_Attributes.md">CapyKit.Attributes</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public string GetFormatParameterizedString(
	int index = 0
)
```
**F#**
``` F#
member GetFormatParameterizedString : 
        ?index : int 
(* Defaults:
        let _index = defaultArg index 0
*)
-> string 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a>  (Optional)</dt><dd>(Optional) Zero-based index of the item in the string to format.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
A formatted string with the specified index and format.

## See Also


#### Reference
<a href="T_CapyKit_Attributes_ValueFormatAttribute.md">ValueFormatAttribute Class</a>  
<a href="N_CapyKit_Attributes.md">CapyKit.Attributes Namespace</a>  
