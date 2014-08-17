// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/Math/Int")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Divides two integer variables and returns the whole number remainder.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Modulus Int", "Divides two integer variables and returns the whole number remainder.\n\nA modulo B is the remainder of A÷B.\n\n[ A % B ]")]
public class hyenApp_ModulusInt : uScriptLogic {
	
	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("A", "The dividend.")] int A,
		[FriendlyName("B", "The divisor. (Must be a non-zero value!)")] int B,
		[FriendlyName("Result", "The integer quotient or result of the operation.")] out int IntResult,
		[FriendlyName("Float Result", "The floating-point quotient or result of the operation."), SocketState(false, false)] out float FloatResult
	) {
		if (B == 0) {
			uScriptDebug.Log("[Modulus Int] You cannot divide by 0. Returning 0 as the result.", uScriptDebug.Type.Error);
			FloatResult = 0f;
			IntResult = 0;
		} else {
			int total = A % B;
			IntResult = total;
			FloatResult = (float)A % (float)B;
		}
		
	}
	
}
