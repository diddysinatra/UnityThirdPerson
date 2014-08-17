// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects/Movement")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set the rotation of the Target GameObject(s) in world space with a Quaternion.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.uscript.net/forum/viewtopic.php?f=21&t=1841")]

[FriendlyName("Set Rotation (Quaternion)", "Set the rotation of the Target GameObject(s) in world space with a Quaternion.")]
public class hyenApp_SetRotationQuaternion : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target GameObject(s) to rotate.")] GameObject[] Target,
		[FriendlyName("Rotation", "The Quaternion Rotation to set to the Target GameObject(s).")] Quaternion rotation
	) {
		foreach ( GameObject obj in Target ){
			obj.transform.rotation = rotation;
		}
		
	}
	
}
