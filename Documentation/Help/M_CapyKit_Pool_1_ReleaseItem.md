# ReleaseItem Method


Releases the lock on the specified item and returns it to the pool.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public void ReleaseItem(
	PoolItem<T> item
)
```
**VB**
``` VB
Public Sub ReleaseItem ( 
	item As PoolItem(Of T)
)
```
**C++**
``` C++
public:
void ReleaseItem(
	PoolItem<T>^ item
)
```
**F#**
``` F#
member ReleaseItem : 
        item : PoolItem<'T> -> unit 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_PoolItem_1">PoolItem</a>(<a href="T_CapyKit_Pool_1">T</a>)</dt><dd>The item to release.</dd></dl>

## Remarks
This method sets the <a href="P_CapyKit_PoolItem_1_Locked">Locked</a> flag to false so that it can be retrieved by <a href="M_CapyKit_Pool_1_GetAvailableItem">GetAvailableItem()</a>.

## See Also


#### Reference
<a href="T_CapyKit_Pool_1">Pool(T) Class</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
