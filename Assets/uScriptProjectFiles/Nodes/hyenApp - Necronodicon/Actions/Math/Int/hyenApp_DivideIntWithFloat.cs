// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Int")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Divides a Int with a Float.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Divide Int With Float", "Divides a Int with a Float. \n\n[ Int / Float ]")]
public class hyenApp_DivideIntWithFloat : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Int", "The Int you wish to divide with.")] int A,
		[FriendlyName("Float", "The Float you wish to divide with.")] float B,
		[FriendlyName("Result", "The integer quotient or result of the operation.")] out int IntResult,
		[FriendlyName("Float Result", "The floating-point quotient or result of the operation."), SocketState(false, false)] out float FloatResult
	) {
		if (B == 0) {
			uScriptDebug.Log("[Divide Int With Float] You cannot divide by 0. Returning 0 as the result.", uScriptDebug.Type.Error);
			FloatResult = 0f;
			IntResult = 0;
		} else {
			FloatResult = A / B;
			IntResult = (int)FloatResult;
			
		}
		
	}
	
}
