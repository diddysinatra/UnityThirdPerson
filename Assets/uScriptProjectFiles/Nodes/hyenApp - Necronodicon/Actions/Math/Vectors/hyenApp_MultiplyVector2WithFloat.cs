// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Multiplies a Vector2 with a Float.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Multiply Vector2 With Float", "Multiplies a Vector2 with a Float. This is useful for multiplying things like Delta Time with a Vector2 velocity for example.")]
public class hyenApp_MultiplyVector2WithFloat : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Vector2", "The Vector2 you wish to multiple with.")] Vector2 targetVector2,
		[FriendlyName("Float", "The Float you wish to multiple with.")] float targetFloat,
		[FriendlyName("Result", "The Vector2 result of the operation.")] out Vector2 Result
	) {
		Result = targetVector2 * targetFloat;
	}
	
}
