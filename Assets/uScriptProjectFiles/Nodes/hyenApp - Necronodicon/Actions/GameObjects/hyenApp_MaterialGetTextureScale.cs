// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the placement scale of texture propertyName.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Material Get Texture Scale", "Gets the placement scale of texture propertyName. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_MaterialGetTextureScale : uScriptLogic {
	
	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Target", "The GameObject to get the texture scale from.")] GameObject target,
		[FriendlyName("Property Name", "The texture Property Name used to scale the Target GameObject(s).")] [SocketState(false, false)] [DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Scale", "Returns the Vector2 Offset of the Target GameObjects texture Property Name.")] out Vector2 scale
	) {
		scale = target.renderer.material.GetTextureScale(propertyName);
		
	}
	
}
