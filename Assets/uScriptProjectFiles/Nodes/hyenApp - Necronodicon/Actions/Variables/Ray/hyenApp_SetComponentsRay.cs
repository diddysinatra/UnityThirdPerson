// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Ray")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip( "Sets the components of a Ray as Vector3.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Components Ray", "Sets the components of a Ray as Vector3.")]
public class hyenApp_SetComponentsRay : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Origin", "Origin value to use for the Output Ray.")] Vector3 Origin,
		[FriendlyName("Direction", "Direction value to use for the Output Ray.")] Vector3 Direction,
		[FriendlyName("Output Ray", "Ray variable built from the specified X and Y.")] out Ray OutputRay
	){
		OutputRay = new Ray(Origin, Direction);
		
	}

}
