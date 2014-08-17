// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/Math/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Divides two float variables and returns the remainder.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Modulus Float", "Divides two float variables and returns the remainder.\n\nA modulo B is the remainder of A÷B.\n\n[ A % B ]")]
public class hyenApp_ModulusFloat : uScriptLogic {
	
	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("A", "The dividend.")] float A,
		[FriendlyName("B", "The divisor. (Must be a non-zero value!)")] float B,
		[FriendlyName("Result", "The floating-point quotient or result of the operation.")] out float FloatResult,
		[FriendlyName("Int Result", "The integer quotient or result of the operation."), SocketState(false, false)] out int IntResult
	) {
		if (B == 0) {
			uScriptDebug.Log("[Modulus Float] You cannot divide by 0. Returning 0 as the result.", uScriptDebug.Type.Error);
			FloatResult = 0f;
			IntResult = 0;
		} else {
			float total = A % B;
			FloatResult = total;
			IntResult = System.Convert.ToInt32(total);
		}
		
	}
	
}
