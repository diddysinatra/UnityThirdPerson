// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Recalculate the bounding volume of the mesh from the vertices.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Recalculate Bounds", "Recalculate the bounding volume of the mesh from the vertices.")]
public class hyenApp_RecalculateBounds : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Target", "The Target GameObject.")] GameObject Target
	) {
		Mesh mesh = Target.GetComponent<MeshFilter>().mesh;
		
		if(mesh != null) {
			mesh.RecalculateBounds();
		}
		
	}
	
}