// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get a Material's texture.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Texture (Material)", "Get a Material's named texture property. \n\nMany shaders use more than one texture. Use Get Texture to get the Property Name texture. \n\nCommon texture names used by Unity's builtin shaders: \n'_MainTex' is the main diffuse texture. \n'_BumpMap' is the normal map. \n'_Cube' is the reflection cubemap.")]
public class hyenApp_GetTextureMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material to get the Texture property from.")] Material material,
		[FriendlyName("Property Name", "The texture Property Name used to Get the Material Texture2D."), SocketState(false, false), DefaultValue("_MainTex")] string propertyName,
		[FriendlyName("Texture", "The Texture component from the target Material."), SocketState(false, false)] out Texture texture,
		[FriendlyName("Texture2D", "The Texture2D component from the target Material.")] out Texture2D texture2D
	) {
		texture = material.GetTexture(propertyName);
		texture2D = texture as Texture2D;
		
	}
	
}
