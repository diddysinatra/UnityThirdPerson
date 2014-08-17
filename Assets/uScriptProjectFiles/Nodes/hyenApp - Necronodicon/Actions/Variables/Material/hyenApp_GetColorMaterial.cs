// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get a Material's Color.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Color (Material)", "Get a Material's named Color property. \n\nMany shaders use more than one color. Use Get Color to get the Property Name color. \n\nCommon color names used by Unity's builtin shaders: \n'_Color' is the main color of a material. \n'_SpecColor' is the specular color of a material (used in specular/glossy/vertexlit shaders). \n'_Emission' is the emissive color of a material (used in vertexlit shaders). \n'_ReflectColor' is the reflection color of the material (used in reflective shaders).")]
public class hyenApp_GetColorMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material to get the Color property from.")] Material material,
		[FriendlyName("Property Name", "The color Property Name used to Get the Material Color."), SocketState(false, false), DefaultValue("_Color")] string propertyName,
		[FriendlyName("Color", "The Color component from the target Material.")] out Color color
	) {
		color = material.GetColor(propertyName);
		
	}
	
}
