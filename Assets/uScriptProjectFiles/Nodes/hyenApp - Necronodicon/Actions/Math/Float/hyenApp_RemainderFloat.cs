// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip( "Finds the remainder of division of two float variables and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Remainder Float", "Finds the remainder of division of two float variables and returns the result.\n\n[ A % B ]")]
public class hyenApp_RemainderFloat : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("A", "The dividend.")] float A,
		[FriendlyName("B", "The divisor.  Must be a non-zero value.")] float B,
		[FriendlyName("Result", "The floating-point quotient or result of the operation.")] out float FloatResult,
		[FriendlyName("Int Result", "The integer quotient or result of the operation.")] [SocketState(false, false)] out int IntResult
	) {
		if (B == 0) {
			uScriptDebug.Log("[Remainder Int] You cannot divide by 0.  Returning 0 as the result.", uScriptDebug.Type.Error);
			FloatResult = 0f;
			IntResult = 0;
		} else {
			float total = A % B;
			FloatResult = total;
			IntResult = System.Convert.ToInt32(total);
		}
		
	}
	
}
