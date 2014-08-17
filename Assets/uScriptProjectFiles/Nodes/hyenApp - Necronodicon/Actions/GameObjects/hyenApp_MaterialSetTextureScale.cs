// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the placement scale of texture propertyName.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Material Set Texture Scale", "Sets the placement scale of texture propertyName. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_MaterialSetTextureScale : uScriptLogic {
	
	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Target", "The GameObject(s) to assign the texture offset to.")] GameObject[] target,
		[FriendlyName("Property Name", "The texture Property Name used to scale the Target GameObject(s).")] [SocketState(false, false)] [DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Scale", "The Vector2 used to Scale the Target GameObject(s) texture Property Name.")] Vector2 scale
	) {
		try {
			foreach (GameObject tmpGameObject in target) {
				tmpGameObject.renderer.material.SetTextureScale(propertyName,scale);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("(Node = Material Set Texture Scale) Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
