// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get a Material's Texture Offset.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Texture Offset (Material)", "Gets the placement offset of texture Property Name. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_GetTextureOffsetMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material to get the Texture Offset property from.")] Material material,
		[FriendlyName("Property Name", "The texture Property Name used to Get the Material's Texture Offset."), SocketState(false, false), DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Texture Offset", "The Texture Offset component from the target Material.")] out Vector2 textureOffset
	) {
		textureOffset = material.GetTextureOffset(propertyName);
		
	}
	
}
