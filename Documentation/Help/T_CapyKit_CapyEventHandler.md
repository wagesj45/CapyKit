# CapyEventHandler Delegate


A delegate representing an event handler that accepts a <a href="T_CapyKit_CapyEventArgs.md">CapyEventArgs</a> instance.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

**C#**
``` C#
public delegate void CapyEventHandler(
	CapyEventArgs e
)
```
**F#**
``` F#
type CapyEventHandler = 
    delegate of 
        e : CapyEventArgs -> unit
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_CapyEventArgs.md">CapyEventArgs</a></dt><dd>The CapyEventArgs instance containing event data.</dd></dl>

## See Also


#### Reference
<a href="N_CapyKit.md">CapyKit Namespace</a>  
