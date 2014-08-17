// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set a Material(s) named matrix for the shader.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.hyenapp.com")]

[FriendlyName("Set Matrix (Material)", "Sets a named matrix for the shader. \n\nThis is mostly used with custom shaders that need extra matrix parameters. Matrix parameters are not exposed in the material inspector, but can be set and queried with Set Matrix and Get Matrix nodes.")]
public class hyenApp_SetMatrixMaterial : uScriptLogic {
	
	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material(s) to assign the Matrix to.")] ref Material[] materials,
		[FriendlyName("Property Name", "The shader Property Name used to set the Material(s) matrix.")] string propertyName,
		[FriendlyName("Matrix4x4", "The Matrix used to replace the Material(s) shader matrix Property Name.")] Matrix4x4 matrix4x4
	) {
		try {
			foreach (Material material in materials) {
				material.SetMatrix(propertyName, matrix4x4);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Set Matrix (Material) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
