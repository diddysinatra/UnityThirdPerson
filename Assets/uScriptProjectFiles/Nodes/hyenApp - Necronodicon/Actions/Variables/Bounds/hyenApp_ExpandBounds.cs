// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Bounds")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Expand the bounds by increasing its size by amount along each side.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Expand Bounds", "Expands the value of a Bounds variable by increasing its size by Amount along each side.\n\nNote: If a Vector3 Amount is specified then any Float Amount will be ignored.")]
public class hyenApp_ExpandBounds : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target Bounds variable you wish to exspand.")] Bounds Target,
		[FriendlyName("Amount Float", "Exspand the Bounds variable by increasing its size with this Float value.")] float amountFloat,
		[FriendlyName("Amount Vector3", "Exspand the Bounds variable by increasing its size with this Vector3 value."), SocketState(false, false)] Vector3 amountVector3,
		[FriendlyName("Result", "The Resulting Expanded Bounds value. ")] out Bounds Result
	) {
		Result = Target;
		
		if (amountVector3 != Vector3.zero) {
			Result.Expand(amountVector3);
		} else if (amountFloat != 0) {
			Result.Expand(amountFloat);
		}
		
	}
	
}
