# GetDistance(Double, Double, Double, Double, MeasurementSystem) Method


Gets the distance between two points on earth using the `haversine` formula.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static double GetDistance(
	double latitudeOrigin,
	double longitudeOrigin,
	double latitudeDestination,
	double longitudeDestination,
	MeasurementSystem measurementSystem = MeasurementSystem.Imperial
)
```
**F#**
``` F#
static member GetDistance : 
        latitudeOrigin : float * 
        longitudeOrigin : float * 
        latitudeDestination : float * 
        longitudeDestination : float * 
        ?measurementSystem : MeasurementSystem 
(* Defaults:
        let _measurementSystem = defaultArg measurementSystem MeasurementSystem.Imperial
*)
-> float 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.double" target="_blank" rel="noopener noreferrer">Double</a></dt><dd>The latitude of the origin.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.double" target="_blank" rel="noopener noreferrer">Double</a></dt><dd>The longitude of the origin.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.double" target="_blank" rel="noopener noreferrer">Double</a></dt><dd>The latitude destination.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.double" target="_blank" rel="noopener noreferrer">Double</a></dt><dd>The longitude destination.</dd><dt>  <a href="T_CapyKit_Enumerations_MeasurementSystem.md">MeasurementSystem</a>  (Optional)</dt><dd>(Optional) The measurement system.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.double" target="_blank" rel="noopener noreferrer">Double</a>  
The distance.

## Remarks
Uses the <a href="https://www.movable-type.co.uk/scripts/latlong.html">

haversine</a> formula to calculate the "as-the-crow-flies" distance between two points on earth.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_CalculationHelper.md">CalculationHelper Class</a>  
<a href="Overload_CapyKit_Helpers_CalculationHelper_GetDistance.md">GetDistance Overload</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
