# CapyKit Namespace


\[Missing &lt;summary&gt; documentation for "N:CapyKit"\]



## Classes
<table>
<tr>
<td><a href="T_CapyKit_CapyEventArgs">CapyEventArgs</a></td>
<td>The CapyEventArgs class represents an event argument instance with event level, message, and method name information.</td></tr>
<tr>
<td><a href="T_CapyKit_CapyEventReporter">CapyEventReporter</a></td>
<td>The CapyEventReporter class is responsible for managing event subscriptions and emissions within CapyKit.</td></tr>
<tr>
<td><a href="T_CapyKit_Password">Password</a></td>
<td>Represents a password with its hash, salt and algorithm used for encryption.</td></tr>
<tr>
<td><a href="T_CapyKit_Pbkdf2Algorithm">Pbkdf2Algorithm</a></td>
<td>Implements the PBKDF2 algorithm for password encryption.</td></tr>
<tr>
<td><a href="T_CapyKit_Pool_1">Pool(T)</a></td>
<td>A managed pool of resources. This class provides a thread-safe way to manage a collection of objects of type <em>T</em>.</td></tr>
<tr>
<td><a href="T_CapyKit_PoolItem_1">PoolItem(T)</a></td>
<td>A pool item. This class cannot be inherited.</td></tr>
<tr>
<td><a href="T_CapyKit_PropertyComparer_2">PropertyComparer(T, U)</a></td>
<td>A object comparer that can accept a lambda expression to compare properties.</td></tr>
</table>

## Interfaces
<table>
<tr>
<td><a href="T_CapyKit_IPasswordAlgorithm">IPasswordAlgorithm</a></td>
<td>Defines the contract for password encryption algorithms.</td></tr>
</table>

## Delegates
<table>
<tr>
<td><a href="T_CapyKit_CapyEventHandler">CapyEventHandler</a></td>
<td>A delegate representing an event handler that accepts a <a href="T_CapyKit_CapyEventArgs">CapyEventArgs</a> instance.</td></tr>
</table>

## Enumerations
<table>
<tr>
<td><a href="T_CapyKit_Color">Color</a></td>
<td>Enum representing a set of named colors with their corresponding HEX values. These colors are inspired by the XKCD color palette (<a href="https://xkcd.com/color/rgb/" target="_blank" rel="noopener noreferrer">Link</a>).</td></tr>
<tr>
<td><a href="T_CapyKit_EventLevel">EventLevel</a></td>
<td>Enumeration representing different event level severity values.</td></tr>
</table>