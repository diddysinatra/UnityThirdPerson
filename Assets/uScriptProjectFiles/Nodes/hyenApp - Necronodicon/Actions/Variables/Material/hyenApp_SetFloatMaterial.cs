// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set a Material(s) named float value.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Float (Material)", "Set a Material(s) named float value.")]
public class hyenApp_SetFloatMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material(s) to assign the Float to.")] ref Material[] materials,
		[FriendlyName("Property Name", "The shader Property Name used to set the Material(s) Float value.")] string propertyName,
		[FriendlyName("Float", "The Float used to replace the Material(s) shader float Property Name.")] float Float
	) {
		try {
			foreach (Material material in materials) {
				material.SetFloat(propertyName, Float);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Set Float (Material) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
