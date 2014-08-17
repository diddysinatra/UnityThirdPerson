// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the Camera component of the Target GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Camera", "Gets the Camera component of the Target GameObject.")]
public class hyenApp_GetCamera : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In (
		[FriendlyName("Target", "The GameObject you wish to get the Camera for.")] GameObject Target,
		[FriendlyName("Camera", "The Camera of the target GameObject.")] out Camera targetCamera
	) {
		if ( null != Target ) {
			targetCamera = Target.camera;
		} else {
			uScriptDebug.Log ("(Node - Get Camera): The specified Target GameObject was null.", uScriptDebug.Type.Warning);
			targetCamera = null;
		}
		
	}
	
}
