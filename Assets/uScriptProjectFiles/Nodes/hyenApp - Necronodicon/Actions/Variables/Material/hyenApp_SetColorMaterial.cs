// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set a Material(s) Color.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Color (Material)", "Set a Material(s) named Color property. \n\nMany shaders use more than one color. Use Set Color to change the Property Name color. \n\nCommon color names used by Unity's builtin shaders: \n'_Color' is the main color of a material. \n'_SpecColor' is the specular color of a material (used in specular/glossy/vertexlit shaders). \n'_Emission' is the emissive color of a material (used in vertexlit shaders). \n'_ReflectColor' is the reflection color of the material (used in reflective shaders).")]
public class hyenApp_SetColorMaterial : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Material", "The Material(s) to assign the color to.")] ref Material[] materials,
		[FriendlyName("Property Name", "The color Property Name used to set the Material(s)."), SocketState(false, false), DefaultValue("_Color")] string propertyName,
		[FriendlyName("Color", "The Color used to replace the Material(s) color Property Name.")] Color color
	) {
		try {
			foreach (Material material in materials) {
				material.SetColor(propertyName, color);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Set Color (Material) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
