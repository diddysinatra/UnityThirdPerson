// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Divide a Vector2 and Float variables and returns the result.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Divide Vector2 With Float", "Divide a Vector2 and Float variables and returns the result.")]
public class hyenApp_DivideVector2WithFloat : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Vector2", "The Vector2 you wish to divide with.")] Vector2 targetVector2,
		[FriendlyName("Float", "The Float you wish to divide with.")] float targetFloat,
		[FriendlyName("Result", "The Vector2 result of the operation.")] out Vector2 Result
	) {
		Result = targetVector2 / targetFloat;
	}
	
}
