// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Averages GameObject positions together and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Average Position", "Averages GameObject positions together and returns the result. \n\nThe result is obtained by adding several quantities together and then devising this total by the number of quantities.")]
public class hyenApp_AveragePosition : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Quantities", "The GameObject to be averaged together.")] GameObject[] Quantities,
		[FriendlyName("Result", "The Vector3 result of the operation.")] out Vector3 Result
	) {
		Vector3 Total = Vector3.zero;

		foreach (GameObject currentQuantity in Quantities) {
			Total += currentQuantity.transform.position;
		}
		
 		if (Quantities.Length == 0) {
			uScriptDebug.Log("[Average Position] You cannot divide by 0.  Returning Vector3.zero as the result.", uScriptDebug.Type.Error);
			Result = Vector3.zero;
		} else {
			Result = Total / Quantities.Length;
		}
		
	}
	
}
