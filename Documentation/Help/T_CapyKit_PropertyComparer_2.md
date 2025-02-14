# PropertyComparer&lt;T, U&gt; Class


A object comparer that can accept a lambda expression to compare properties.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public class PropertyComparer<T, U> : IEqualityComparer<T>

```
**F#**
``` F#
type PropertyComparer<'T, 'U> = 
    class
        interface IEqualityComparer<'T>
    end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  PropertyComparer(T, U)</td></tr>
<tr><td><strong>Implements</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1" target="_blank" rel="noopener noreferrer">IEqualityComparer</a>(T)</td></tr>
</table>



#### Type Parameters
<dl><dt /><dd>Generic type parameter of the parent object.</dd><dt /><dd>Generic type parameter of the property value.</dd></dl>

## Example
using System; using System.Collections.Generic; using System.Linq; class Program { static void Main(string[] args) { var people = new List&lt;Person&gt; { new Person { Name = "Alice", Age = 30 }, new Person { Name = "Bob", Age = 30 }, new Person { Name = "Charlie", Age = 35 } }; var comparer = new PropertyComparer&lt;Person, int&gt;(p =&gt; p.Age); var distinctPeople = people.Distinct(comparer).ToList(); foreach (var person in distinctPeople) { Console.WriteLine($"{person.Name} - {person.Age}"); } } } class Person { public string Name { get; set; } public int Age { get; set; } }

## Constructors
<table>
<tr>
<td><a href="M_CapyKit_PropertyComparer_2__ctor.md">PropertyComparer(T, U)</a></td>
<td>Constructor.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals(Object)</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_PropertyComparer_2_Equals.md">Equals(T, T)</a></td>
<td>Determines whether the specified properties are equal.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.finalize" target="_blank" rel="noopener noreferrer">Finalize</a></td>
<td>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode()</a></td>
<td>Serves as the default hash function.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_PropertyComparer_2_GetHashCode.md">GetHashCode(T)</a></td>
<td>Returns a hash code for the specified object.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone" target="_blank" rel="noopener noreferrer">MemberwiseClone</a></td>
<td>Creates a shallow copy of the current <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_CapyKit_PropertyComparer_2_expression.md">expression</a></td>
<td>The expression to retrieve the property.</td></tr>
</table>

## Extension Methods
<table>
<tr>
<td><a href="M_CapyKit_Extensions_ObjectExtensions_UpdateProperties.md">UpdateProperties</a></td>
<td>An object extension method that updates the properties of a given <em>target</em> object with the values from a given <em>source</em> object.<br />(Defined by <a href="T_CapyKit_Extensions_ObjectExtensions.md">ObjectExtensions</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit.md">CapyKit Namespace</a>  
