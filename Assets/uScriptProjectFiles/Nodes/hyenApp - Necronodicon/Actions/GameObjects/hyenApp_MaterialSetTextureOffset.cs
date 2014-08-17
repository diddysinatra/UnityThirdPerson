// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the placement offset of texture propertyName.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Material Set Texture Offset", "Sets the placement offset of texture Property Name. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_MaterialSetTextureOffset : uScriptLogic {
	
	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Target", "The GameObject(s) to assign the texture offset to.")] GameObject[] target,
		[FriendlyName("Property Name", "The texture Property Name used to offset the Target GameObject(s).")] [SocketState(false, false)] [DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Offset", "The Vector2 used to Offset the Target GameObject(s) texture Property Name.")] Vector2 offset
	) {
		try {
			foreach (GameObject tmpGameObject in target) {
				tmpGameObject.renderer.material.SetTextureOffset(propertyName,offset);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("(Node = Material Set Texture Offset) Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
