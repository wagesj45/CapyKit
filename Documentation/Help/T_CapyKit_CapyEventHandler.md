# CapyEventHandler Delegate


A delegate representing an event handler that accepts a <a href="T_CapyKit_CapyEventArgs">CapyEventArgs</a> instance.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public delegate void CapyEventHandler(
	CapyEventArgs e
)
```
**VB**
``` VB
Public Delegate Sub CapyEventHandler ( 
	e As CapyEventArgs
)
```
**C++**
``` C++
public delegate void CapyEventHandler(
	CapyEventArgs^ e
)
```
**F#**
``` F#
type CapyEventHandler = 
    delegate of 
        e : CapyEventArgs -> unit
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_CapyEventArgs">CapyEventArgs</a></dt><dd>The CapyEventArgs instance containing event data.</dd></dl>

## See Also


#### Reference
<a href="N_CapyKit">CapyKit Namespace</a>  
