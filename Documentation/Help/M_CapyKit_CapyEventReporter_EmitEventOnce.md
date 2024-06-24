# EmitEventOnce Method


Emits an event with the given severity level, message, unique identifier, and method name one time.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

**C#**
``` C#
public static void EmitEventOnce(
	EventLevel eventLevel,
	string message,
	string uniqueIdentifier,
	string method = null,
	params Object[] args
)
```
**F#**
``` F#
static member EmitEventOnce : 
        eventLevel : EventLevel * 
        message : string * 
        uniqueIdentifier : string * 
        ?method : string * 
        args : Object[] 
(* Defaults:
        let _method = defaultArg method null
*)
-> unit 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_EventLevel.md">EventLevel</a></dt><dd>The severity level of the event.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The message describing the reason for the event. String formatting for <em>args</em> is accepted.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>A unique identifier for the event emission.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  (Optional)</dt><dd>(Optional) The name of the method where the event was raised.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>A variable-length parameters list containing arguments for formatting the message.</dd></dl>

## Remarks
This method is similar to [!:EmitEvent(EventLevel, string, string, string, object[])] , but requires a unique identifier (such as a <a href="https://learn.microsoft.com/dotnet/api/system.guid" target="_blank" rel="noopener noreferrer">Guid</a>) to prevent duplicate emissions.

## See Also


#### Reference
<a href="T_CapyKit_CapyEventReporter.md">CapyEventReporter Class</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
<a href="https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.callermembernameattribute" target="_blank" rel="noopener noreferrer">CallerMemberNameAttribute</a>  
<a href="https://learn.microsoft.com/dotnet/api/system.guid" target="_blank" rel="noopener noreferrer">Guid</a>  
