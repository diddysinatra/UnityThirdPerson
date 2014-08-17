// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Gizmos")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set the gizmo matrix used to draw all gizmos.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Matrix (Gizmos)", "Set the gizmo Matrix4x4 used to draw all gizmos.")]
public class hyenApp_GizmosSetMatrix : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Matrix", "The Matrix4x4 you wish to use for the gizmos that will be drawn next.")] Matrix4x4 matrix
	) {
		Gizmos.matrix = matrix;
		
	}
	
}
