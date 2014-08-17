// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Texture2D")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns pixel color at coordinates (x, y) from a Texture2D.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Pixel Color (Texture2D)", "Returns pixel color at coordinates (x, y) from the Input Texture2D.\nIf the pixel coordinates are out of bounds (larger than width/height or small than 0), they will be clamped or repeat based on the texture's wrap mode.\n\nNOTE: The texture must have the Is Readable flag set in the import settings, otherwise this node will fail!")]
public class hyenApp_GetPixelColorTexture2D : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Texture2D", "The Texture2D to get Color at coordinates (x, y) from.")] Texture2D inputTexture2D,
		//[FriendlyName("Coordinates", "Vector2 coordinates (x, y)")] Vector2 Coordinates,
		[FriendlyName("X", "The X coordinate.")] int X,
		[FriendlyName("Y", "The Y coordinate.")] int Y,
		[FriendlyName("Color", "The pixel Color at coordinates (x, y).")] out Color outColor
	) {
		outColor = inputTexture2D.GetPixel(X, Y);
		
	}

}
