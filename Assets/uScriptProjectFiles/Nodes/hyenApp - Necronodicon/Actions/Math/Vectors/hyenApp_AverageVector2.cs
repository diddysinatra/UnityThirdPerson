// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Averages Vector2 variables together and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Average Vector2", "Averages Vector2 variables together and returns the result. \n\nThe result is obtained by adding several quantities together and then devising this total by the number of quantities.")]
public class hyenApp_AverageVector2 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Quantities", "The Vector2 to be averaged together.")] Vector2[] Quantities,
		[FriendlyName("Result", "The Vector2 result of the operation.")] out Vector2 Result
	) {
		Vector2 Total = Vector2.zero;

		foreach (Vector2 currentQuantity in Quantities) {
			Total += currentQuantity;
		}
		
 		if (Quantities.Length == 0) {
			uScriptDebug.Log("[Average Vector2] You cannot divide by 0.  Returning Vector2.zero as the result.", uScriptDebug.Type.Error);
			Result = Vector2.zero;
		} else {
			Result = Total / Quantities.Length;
		}
		
	}
	
}
