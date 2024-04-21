# CapyEventArgs Constructor


Initializes a new instance of the CapyEventArgs class with the specified event level, message, and method name.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public CapyEventArgs(
	EventLevel level,
	string message,
	string method = null
)
```
**F#**
``` F#
new : 
        level : EventLevel * 
        message : string * 
        ?method : string 
(* Defaults:
        let _method = defaultArg method null
*)
-> CapyEventArgs
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_EventLevel.md">EventLevel</a></dt><dd>The severity level of the event.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>A descriptive message explaining the reason for the event.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  (Optional)</dt><dd>The name of the method where the event was raised.</dd></dl>

## See Also


#### Reference
<a href="T_CapyKit_CapyEventArgs.md">CapyEventArgs Class</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
