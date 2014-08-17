// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set a Material(s) Texture Scale.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Texture Scale (Material)", "Sets the placement scale of texture Property Name. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_SetTextureScaleMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material(s) to assign the Texture Scale to.")] ref Material[] materials,
		[FriendlyName("Property Name", "The texture Property Name used to set the Material(s)."), SocketState(false, false), DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Texture Scale", "The Texture Scale used to replace the Material(s) texture scale Property Name.")] Vector2 textureScale
	) {
		try {
			foreach (Material material in materials) {
				material.SetTextureScale(propertyName, textureScale);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Set Color (Material) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
