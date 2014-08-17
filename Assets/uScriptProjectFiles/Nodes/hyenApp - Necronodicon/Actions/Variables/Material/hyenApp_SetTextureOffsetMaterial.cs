// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set a Material(s) Texture Offset.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Texture Offset (Material)", "Sets the placement offset of texture Property Name. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_SetTextureOffsetMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material(s) to assign the Texture Offset to.")] ref Material[] materials,
		[FriendlyName("Property Name", "The texture Property Name used to set the Material(s)."), SocketState(false, false), DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Texture Offset", "The Texture Offset used to replace the Material(s) texture offset Property Name.")] Vector2 textureOffset
	) {
		try {
			foreach (Material material in materials) {
				material.SetTextureOffset(propertyName, textureOffset);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Set Texture Offset (Material) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
