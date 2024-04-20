# IPasswordAlgorithm Interface


Defines the contract for password encryption algorithms.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public interface IPasswordAlgorithm
```
**VB**
``` VB
Public Interface IPasswordAlgorithm
```
**C++**
``` C++
public interface class IPasswordAlgorithm
```
**F#**
``` F#
type IPasswordAlgorithm = interface end
```



## Properties
<table>
<tr>
<td><a href="P_CapyKit_IPasswordAlgorithm_AlgorithmName">AlgorithmName</a></td>
<td>Gets the name of the algorithm.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_CapyKit_IPasswordAlgorithm_Compare">Compare</a></td>
<td>Compares the given plaintext password with an encrypted value using PBKDF2 algorithm.</td></tr>
<tr>
<td><a href="M_CapyKit_IPasswordAlgorithm_Encrypt">Encrypt</a></td>
<td>Encrypts the given password using a defined algorithm.</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit">CapyKit Namespace</a>  
