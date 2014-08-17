// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Camera")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the GameObject a Camera is attached to.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Camera GameObject", "Gets the GameObject a Camera is attached to.")]
public class hyenApp_GetCameraGameObject : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Target", "The Camera.")] Camera camera,
		[FriendlyName("GameObject", "The returned GameObject of the Camera.")] out GameObject gameObject
	) {
		gameObject = camera.gameObject;
		
	}
	
}
