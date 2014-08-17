// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set a Material(s) texture.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Texture (Material)", "Set a Material(s) named texture property. \n\nMany shaders use more than one texture. Use Set Texture to change the Property Name texture. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_SetTextureMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material(s) to assign the texture to.")] ref Material[] materials,
		[FriendlyName("Property Name", "The texture Property Name used to set the Material(s)."), SocketState(false, false), DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Texture", "The Texture used to replace the Material(s) texture Property Name."), SocketState(false, false)] Texture texture,
		[FriendlyName("Texture2D", "The Texture2D used to replace the Material(s) texture Property Name.")] Texture2D texture2D
	) {
		try {
			foreach (Material material in materials) {
				if(null != texture) {
					material.SetTexture(propertyName, texture);
				} else if(null != texture2D) {
					material.SetTexture(propertyName, texture2D);
				}
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Set Texture (Material) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
