// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Averages Vector3 variables together and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Average Vector3", "Averages Vector3 variables together and returns the result. \n\nThe result is obtained by adding several quantities together and then devising this total by the number of quantities.")]
public class hyenApp_AverageVector3 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Quantities", "The Vector3 to be averaged together.")] Vector3[] Quantities,
		[FriendlyName("Result", "The Vector3 result of the operation.")] out Vector3 Result
	) {
		Vector3 Total = Vector3.zero;

		foreach (Vector3 currentQuantity in Quantities) {
			Total += currentQuantity;
		}
		
 		if (Quantities.Length == 0) {
			uScriptDebug.Log("[Average Vector3] You cannot divide by 0.  Returning Vector3.zero as the result.", uScriptDebug.Type.Error);
			Result = Vector3.zero;
		} else {
			Result = Total / Quantities.Length;
		}
		
	}
	
}
