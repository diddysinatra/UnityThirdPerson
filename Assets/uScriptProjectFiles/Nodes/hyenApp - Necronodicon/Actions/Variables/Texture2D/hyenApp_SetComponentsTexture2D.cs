// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Texture2D")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Create and Set the components of a new empty Texture2D.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Components (Texture2D)", "Create and Set the components of a new empty Texture2D. \n\nThe texture will be width by height size, with a given format, with mipmaps or without and in either the linear or sRGB color space. \n\nUsually you will want to set the colors of the texture after creating it, using SetPixel, SetPixels and Apply functions.")]
public class hyenApp_SetComponentsTexture2D : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Width", "Width of the texture in pixels.")] int width,
		[FriendlyName("Height", "Height of the texture in pixels.")] int height,
		[FriendlyName("Format", "The  format of the pixel data in the texture."), SocketState(false, false), DefaultValue(TextureFormat.ARGB32)] TextureFormat format,
		[FriendlyName("Mipmap", ""), SocketState(false, false), DefaultValue(false)] bool mipmap,
		[FriendlyName("Linear", "Linear or sRGB color space"), SocketState(false, false), DefaultValue(false)] bool linear,
		[FriendlyName("Texture2D", "The output Texture2D.")] out Texture2D outputTexture2D
	) {
		outputTexture2D = new Texture2D(width, height, format, mipmap, linear);
		
	}
	
}
