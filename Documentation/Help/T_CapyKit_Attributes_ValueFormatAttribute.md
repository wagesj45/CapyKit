# ValueFormatAttribute Class


Custom attribute for formatting values in a specific way.



## Definition
**Namespace:** <a href="N_CapyKit_Attributes.md">CapyKit.Attributes</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
[AttributeUsageAttribute(AttributeTargets.Property)]
public class ValueFormatAttribute : Attribute
```
**F#**
``` F#
[<AttributeUsageAttribute(AttributeTargets.Property)>]
type ValueFormatAttribute = 
    class
        inherit Attribute
    end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>  →  ValueFormatAttribute</td></tr>
</table>



## Constructors
<table>
<tr>
<td><a href="M_CapyKit_Attributes_ValueFormatAttribute__ctor.md">ValueFormatAttribute()</a></td>
<td>Default constructor. Initializes a new instance of the ValueFormatAttribute class with an empty format string.</td></tr>
<tr>
<td><a href="M_CapyKit_Attributes_ValueFormatAttribute__ctor_1.md">ValueFormatAttribute(String)</a></td>
<td>Constructor. Initializes a new instance of the ValueFormatAttribute class with the specified format string.</td></tr>
</table>

## Properties
<table>
<tr>
<td><a href="P_CapyKit_Attributes_ValueFormatAttribute_Format.md">Format</a></td>
<td>Gets or sets the format to use for formatting the value.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.typeid" target="_blank" rel="noopener noreferrer">TypeId</a></td>
<td>When implemented in a derived class, gets a unique identifier for this <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
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
<td><a href="M_CapyKit_Attributes_ValueFormatAttribute_GetFormatParameterizedString.md">GetFormatParameterizedString</a></td>
<td>Gets a parameterized formatted string for the specified index.</td></tr>
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

## See Also


#### Reference
<a href="N_CapyKit_Attributes.md">CapyKit.Attributes Namespace</a>  
