// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Ray")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Ray as Vector3.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components Ray", "Gets the components of a Ray as Vector3.")]
public class hyenApp_GetComponentsRay : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Input Ray", "The input ray to get components of.")] Ray InputRay,
		[FriendlyName("Origin", "The Origin value of the Input Ray.")] out Vector3 Origin,
		[FriendlyName("Direction", "The Direction value of the Input Ray.")] out Vector3 Direction
	) {
		Origin = InputRay.origin;
		Direction = InputRay.direction;
		
	}

}
