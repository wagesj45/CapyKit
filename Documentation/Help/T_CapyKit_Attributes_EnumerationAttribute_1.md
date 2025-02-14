# EnumerationAttribute&lt;T&gt; Class


Custom attribute class for decorating enumeration fields with additional data.



## Definition
**Namespace:** <a href="N_CapyKit_Attributes.md">CapyKit.Attributes</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
[AttributeUsageAttribute(AttributeTargets.Field)]
public abstract class EnumerationAttribute<T> : Attribute

```
**F#**
``` F#
[<AbstractClassAttribute>]
[<AttributeUsageAttribute(AttributeTargets.Field)>]
type EnumerationAttribute<'T> = 
    class
        inherit Attribute
    end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>  →  EnumerationAttribute(T)</td></tr>
<tr><td><strong>Derived</strong></td><td><a href="T_CapyKit_Attributes_EnumerationDescriptionAttribute.md">CapyKit.Attributes.EnumerationDescriptionAttribute</a></td></tr>
</table>



#### Type Parameters
<dl><dt /><dd>Generic type parameter allowing for arbitrary declarations and assignments of meaning.</dd></dl>

## Constructors
<table>
<tr>
<td><a href="M_CapyKit_Attributes_EnumerationAttribute_1__ctor.md">EnumerationAttribute(T)</a></td>
<td>Gets the value of the enumeration represented by this attribute.</td></tr>
</table>

## Properties
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.typeid" target="_blank" rel="noopener noreferrer">TypeId</a></td>
<td>When implemented in a derived class, gets a unique identifier for this <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="P_CapyKit_Attributes_EnumerationAttribute_1_Value.md">Value</a></td>
<td>Initializes a new instance of the EnumerationAttribute(T) class with a specified value.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.equals" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Returns a value that indicates whether this instance is equal to a specified object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.finalize" target="_blank" rel="noopener noreferrer">Finalize</a></td>
<td>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode</a></td>
<td>Returns the hash code for this instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.isdefaultattribute" target="_blank" rel="noopener noreferrer">IsDefaultAttribute</a></td>
<td>When overridden in a derived class, indicates whether the value of this instance is the default value for the derived class.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.match" target="_blank" rel="noopener noreferrer">Match</a></td>
<td>When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone" target="_blank" rel="noopener noreferrer">MemberwiseClone</a></td>
<td>Creates a shallow copy of the current <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## Extension Methods
<table>
<tr>
<td><a href="M_CapyKit_Extensions_ObjectExtensions_UpdateProperties.md">UpdateProperties</a></td>
<td>An object extension method that updates the properties of a given <em>target</em> object with the values from a given <em>source</em> object.<br />(Defined by <a href="T_CapyKit_Extensions_ObjectExtensions.md">ObjectExtensions</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit_Attributes.md">CapyKit.Attributes Namespace</a>  
