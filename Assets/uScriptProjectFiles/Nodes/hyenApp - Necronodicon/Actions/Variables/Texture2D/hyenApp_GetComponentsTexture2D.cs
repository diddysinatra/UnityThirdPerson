// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Texture2D")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Texture2D.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (Texture2D)", "Gets the components of a Texture2D.")]
public class hyenApp_GetComponentsTexture2D : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Input Texture2D", "The input Texture2D to get components of.")] Texture2D inputTexture2D,
		[FriendlyName("Width", "Width of the texture in pixels (Read Only).")] out int width,
		[FriendlyName("Height", "Height of the texture in pixels (Read Only).")] out int height,
		[FriendlyName("Mipmap Count", "How many mipmap levels are in this texture (Read Only)."), SocketState(false, false)] out int mipmapCount,
		[FriendlyName("Format", "The  format of the pixel data in the texture (Read Only)."), SocketState(false, false)] out TextureFormat format
	) {
		width = inputTexture2D.width;
		height = inputTexture2D.height;
		mipmapCount = inputTexture2D.mipmapCount;
		format = inputTexture2D.format;
		
	}
	
}
