# CapyKit Namespace


Core utilities and foundational methods for the CapyKit library.



## Classes
<table>
<tr>
<td><a href="T_CapyKit_CapyEventArgs.md">CapyEventArgs</a></td>
<td>The CapyEventArgs class represents an event argument instance with event level, message, and method name information.</td></tr>
<tr>
<td><a href="T_CapyKit_CapyEventReporter.md">CapyEventReporter</a></td>
<td>The CapyEventReporter class is responsible for managing event subscriptions and emissions within CapyKit.</td></tr>
<tr>
<td><a href="T_CapyKit_Color.md">Color</a></td>
<td>An object representing a color.</td></tr>
<tr>
<td><a href="T_CapyKit_EncryptedValue_1.md">EncryptedValue(T)</a></td>
<td> </td></tr>
<tr>
<td><a href="T_CapyKit_Password.md">Password</a></td>
<td>Represents a password with its hash, salt and algorithm used for encryption.</td></tr>
<tr>
<td><a href="T_CapyKit_Pbkdf2Algorithm.md">Pbkdf2Algorithm</a></td>
<td>Implements the PBKDF2 algorithm for password encryption.</td></tr>
<tr>
<td><a href="T_CapyKit_Pool_1.md">Pool(T)</a></td>
<td>A managed pool of resources. This class provides a thread-safe way to manage a collection of objects of type <em>T</em>.</td></tr>
<tr>
<td><a href="T_CapyKit_PoolItem_1.md">PoolItem(T)</a></td>
<td>A pool item. This class cannot be inherited.</td></tr>
<tr>
<td><a href="T_CapyKit_PropertyComparer_2.md">PropertyComparer(T, U)</a></td>
<td>A object comparer that can accept a lambda expression to compare properties.</td></tr>
</table>

## Interfaces
<table>
<tr>
<td><a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm</a></td>
<td>Defines the contract for password encryption algorithms.</td></tr>
</table>

## Delegates
<table>
<tr>
<td><a href="T_CapyKit_CapyEventHandler.md">CapyEventHandler</a></td>
<td>A delegate representing an event handler that accepts a <a href="T_CapyKit_CapyEventArgs.md">CapyEventArgs</a> instance.</td></tr>
</table>

## Enumerations
<table>
<tr>
<td><a href="T_CapyKit_EventLevel.md">EventLevel</a></td>
<td>Enumeration representing different event level severity values.</td></tr>
<tr>
<td><a href="T_CapyKit_NamedColor.md">NamedColor</a></td>
<td>Enum representing a set of named colors with their corresponding HEX values. These colors are inspired by the XKCD color palette (<a href="https://xkcd.com/color/rgb/" target="_blank" rel="noopener noreferrer">Link</a>).</td></tr>
</table>