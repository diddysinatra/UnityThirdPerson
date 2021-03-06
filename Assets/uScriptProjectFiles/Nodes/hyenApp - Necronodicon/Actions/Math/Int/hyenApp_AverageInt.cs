// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Int")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Averages int variables together and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Average Int", "Averages int variables together and returns the result. \n\nThe result is obtained by adding several quantities together and then devising this total by the number of quantities.")]
public class hyenApp_AverageInt : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Quantities", "The Ints to be averaged together.")] int[] Quantities,
		[FriendlyName("Result", "The floating-point result of the operation.")] out float FloatResult,
		[FriendlyName("Int Result", "The integer result of the operation."), SocketState(false, false)] out int IntResult
	) {
		int Total = 0;

		foreach (int currentQuantity in Quantities) {
			Total += currentQuantity;
		}
		
 		if (Quantities.Length == 0) {
			uScriptDebug.Log("[Average Int] You cannot divide by 0.  Returning 0 as the result.", uScriptDebug.Type.Error);
			FloatResult = 0f;
			IntResult = 0;
		} else {
			FloatResult = Total / Quantities.Length;
			IntResult = System.Convert.ToInt32(FloatResult);
		}
		
	}
	
}
