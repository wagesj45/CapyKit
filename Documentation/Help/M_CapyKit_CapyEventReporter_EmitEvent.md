# EmitEvent Method


Emits an event with the given severity level, message, and method name.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
internal static void EmitEvent(
	EventLevel eventLevel,
	string message,
	string method = null,
	params Object[] args
)
```
**F#**
``` F#
internal static member EmitEvent : 
        eventLevel : EventLevel * 
        message : string * 
        ?method : string * 
        args : Object[] 
(* Defaults:
        let _method = defaultArg method null
*)
-> unit 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_EventLevel.md">EventLevel</a></dt><dd>The severity level of the event.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The message describing the reason for the event. String formatting for <em>args</em> is accepted.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  (Optional)</dt><dd>(Optional) The name of the method where the event was raised.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>A variable-length parameters list containing arguments for formatting the message.</dd></dl>

## Remarks
In order to allow for efficient calling member access via <a href="https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.callermembernameattribute" target="_blank" rel="noopener noreferrer">CallerMemberNameAttribute</a> , it is suggested that *args* is defined explicitly for formatted messages.

## Example
CapyEventReporter.EmitEvent(EventLevel.Error, "Could not find the description for {0}.", args: new[] { enumeration });

## See Also


#### Reference
<a href="T_CapyKit_CapyEventReporter.md">CapyEventReporter Class</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
<a href="https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.callermembernameattribute" target="_blank" rel="noopener noreferrer">CallerMemberNameAttribute</a>  
