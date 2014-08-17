// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set a Material(s) Vector4 color.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Vector (Material)", "Set a Material(s) named Vector4 color property. Four component vectors and colors are the same in Unity shaders, just the input data type is different (xyzw in the vector becomes rgba in the color). \n\nMany shaders use more than one color. Use Set Vector4 color to change the Property Name color. \n\nCommon color names used by Unity's builtin shaders: \n'_Color' is the main color of a material. \n'_SpecColor' is the specular color of a material (used in specular/glossy/vertexlit shaders). \n'_Emission' is the emissive color of a material (used in vertexlit shaders). \n'_ReflectColor' is the reflection color of the material (used in reflective shaders).")]
public class hyenApp_SetVectorMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material(s) to assign the color to.")] ref Material[] materials,
		[FriendlyName("Property Name", "The color Property Name used to set the Material(s)."), SocketState(false, false), DefaultValue("_Color")] string propertyName,
		[FriendlyName("Vector4", "The Vector4 color used to replace the Material(s) color Property Name.")] Vector4 vector4
	) {
		try {
			foreach (Material material in materials) {
				material.SetVector(propertyName, vector4);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Set Vector (Material) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
