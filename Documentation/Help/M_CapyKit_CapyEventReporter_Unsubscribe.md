# Unsubscribe Method


Unsubscribes the specified event handler from the event with the given origin.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static void Unsubscribe(
	CapyEventHandler callback,
	string origin
)
```
**VB**
``` VB
Public Shared Sub Unsubscribe ( 
	callback As CapyEventHandler,
	origin As String
)
```
**C++**
``` C++
public:
static void Unsubscribe(
	CapyEventHandler^ callback, 
	String^ origin
)
```
**F#**
``` F#
static member Unsubscribe : 
        callback : CapyEventHandler * 
        origin : string -> unit 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_CapyEventHandler">CapyEventHandler</a></dt><dd>The event handler to unsubscribe.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The name of the method or class where the subscription was made.</dd></dl>

## See Also


#### Reference
<a href="T_CapyKit_CapyEventReporter">CapyEventReporter Class</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
