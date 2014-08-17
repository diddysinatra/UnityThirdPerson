// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Camera")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the name of the GameObject a Camera is attached to.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Camera Name", "Gets the name of the GameObject a Camera is attached to.")]
public class hyenApp_GetCameraName : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Target", "The Camera.")] Camera camera,
		[FriendlyName("Name", "The returned name of the Camera.")] out string name
	) {
		name = camera.name;
	}
	
}