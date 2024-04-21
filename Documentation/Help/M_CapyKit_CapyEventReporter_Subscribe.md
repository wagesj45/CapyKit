# Subscribe Method


Subscribes the specified event handler to the event with the given subscription level and origin.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public static void Subscribe(
	CapyEventHandler callback,
	EventLevel subscriptionLevel,
	string origin = null
)
```
**F#**
``` F#
static member Subscribe : 
        callback : CapyEventHandler * 
        subscriptionLevel : EventLevel * 
        ?origin : string 
(* Defaults:
        let _origin = defaultArg origin null
*)
-> unit 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_CapyEventHandler.md">CapyEventHandler</a></dt><dd>The event handler to subscribe.</dd><dt>  <a href="T_CapyKit_EventLevel.md">EventLevel</a></dt><dd>The severity level of the event to subscribe to.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  (Optional)</dt><dd>(Optional) The name of the method or class where the subscription is made.</dd></dl>

## Remarks
If there is no existing list for the given subscription level, a new list is created and added to the dictionary.

## See Also


#### Reference
<a href="T_CapyKit_CapyEventReporter.md">CapyEventReporter Class</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
