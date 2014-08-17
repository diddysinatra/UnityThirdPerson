// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the placement offset of texture Property Name.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Material Get Texture Offset", "Gets the placement offset of texture Property Name. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_MaterialGetTextureOffset : uScriptLogic {
	
	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Target", "The GameObject to get the texture offset from.")] GameObject target,
		[FriendlyName("Property Name", "The texture Property Name used to offset the Target GameObject(s).")] [SocketState(false, false)] [DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Offset", "Returns the Vector2 Offset of the Target GameObjects texture Property Name.")] out Vector2 offset
	) {
		offset = target.renderer.material.GetTextureOffset(propertyName);
		
	}
	
}
