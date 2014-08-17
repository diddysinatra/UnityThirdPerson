// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get a Material's named matrix value from the shader.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.hyenapp.com")]

[FriendlyName("Get Matrix (Material)", "Gets a named matrix value from the shader. \n\nThis is mostly used with custom shaders that need extra matrix parameters. Matrix parameters are not exposed in the material inspector, but can be set and queried with Set Matrix and Get Matrix nodes.")]
public class hyenApp_GetMatrixMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material to get the Matrix property from.")] Material material,
		[FriendlyName("Property Name", "The matrix Property Name used to Get the Material's Matrix.")] string propertyName,
		[FriendlyName("Matrix4x4", "The Matrix component from the target Material.")] out Matrix4x4 matrix4x4
	) {
		matrix4x4 = material.GetMatrix(propertyName);
		
	}
	
}
