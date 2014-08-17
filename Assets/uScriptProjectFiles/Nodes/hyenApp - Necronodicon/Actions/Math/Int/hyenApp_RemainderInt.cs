// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Int")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip( "Finds the remainder of division of two integer variables and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Remainder Int", "Finds the remainder of division of two integer variables and returns the result.\n\n[ A % B ]")]
public class hyenApp_RemainderInt : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("A", "The dividend.")] int A,
		[FriendlyName("B", "The divisor.  Must be a non-zero value.")] int B,
		[FriendlyName("Result", "The integer quotient or result of the operation.")] out int IntResult,
		[FriendlyName("Float Result", "The floating-point quotient or result of the operation.")] [SocketState(false, false)] out float FloatResult
	) {
		if (B == 0) {
			uScriptDebug.Log("[Remainder Int] You cannot divide by 0.  Returning 0 as the result.", uScriptDebug.Type.Error);
			FloatResult = 0f;
			IntResult = 0;
		} else {
			int total = A % B;
			IntResult = total;
			FloatResult = (float)A % (float)B;
		}
		
	}
	
}
