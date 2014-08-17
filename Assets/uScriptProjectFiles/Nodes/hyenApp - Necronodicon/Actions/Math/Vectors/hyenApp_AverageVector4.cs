// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Averages Vector4 variables together and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Average Vector4", "Averages Vector4 variables together and returns the result. \n\nThe result is obtained by adding several quantities together and then devising this total by the number of quantities.")]
public class hyenApp_AverageVector4 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Quantities", "The Vector4 to be averaged together.")] Vector4[] Quantities,
		[FriendlyName("Result", "The Vector4 result of the operation.")] out Vector4 Result
	) {
		Vector4 Total = Vector4.zero;

		foreach (Vector4 currentQuantity in Quantities) {
			Total += currentQuantity;
		}
		
 		if (Quantities.Length == 0) {
			uScriptDebug.Log("[Average Vector4] You cannot divide by 0.  Returning Vector4.zero as the result.", uScriptDebug.Type.Error);
			Result = Vector4.zero;
		} else {
			Result = Total / Quantities.Length;
		}
		
	}
	
}
