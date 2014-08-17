// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get a Material's Vector4 color.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Vector (Material)", "Get a Material's named Vector4 color property. Four component vectors and colors are the same in Unity shaders, just the input data type is different (xyzw in the vector becomes rgba in the color). \n\nMany shaders use more than one color. Use Get Vector4 color to get the Property Name color. \n\nCommon color names used by Unity's builtin shaders: \n'_Color' is the main color of a material. \n'_SpecColor' is the specular color of a material (used in specular/glossy/vertexlit shaders). \n'_Emission' is the emissive color of a material (used in vertexlit shaders). \n'_ReflectColor' is the reflection color of the material (used in reflective shaders).")]
public class hyenApp_GetVectorMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material to get the Vector4 color property from.")] Material material,
		[FriendlyName("Property Name", "The color Property Name used to Get the Material Vector4 color."), SocketState(false, false), DefaultValue("_Color")] string propertyName,
		[FriendlyName("Vector4", "The Vector4 component from the target Material.")] out Vector4 vector4
	) {
		vector4 = material.GetVector(propertyName);
		
	}
	
}
