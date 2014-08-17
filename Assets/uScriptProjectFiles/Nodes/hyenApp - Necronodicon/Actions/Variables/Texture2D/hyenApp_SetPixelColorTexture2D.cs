// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Texture2D")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets pixel color at coordinates (x, y) to a Texture2D.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Pixel Color (Texture2D)", "Sets pixel color at coordinates (x, y) to the Target Texture2D. \n\nIf you're constantly regenerating a texture at runtime, it may be faster to generate an array of pixel colors and set all of them at once with the Set Pixels Color (Texture2D) node. \n\nNOTE: Use the Apply Changes (Texture2D) node to actually upload the changed pixels to the graphics card. Uploading is an expensive operation, so you'll want to change as many pixels as possible between Apply Changes (Texture2D) node calls.")]
public class hyenApp_SetPixelColorTexture2D : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Texture2D", "The Texture2D to Set Color at coordinates (x, y).")] Texture2D[] texture2Ds,
		//[FriendlyName("Coordinates", "Vector2 coordinates (x, y)")] Vector2 Coordinates,
		[FriendlyName("X", "The X coordinate.")] int X,
		[FriendlyName("Y", "The Y coordinate.")] int Y,
		[FriendlyName("Color", "The Color at pixel coordinates (x, y).")] Color color
	) {
		try {
			foreach (Texture2D texture2D in texture2Ds) {
				texture2D.SetPixel(X, Y, color);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Set Pixel Color (Texture2D) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}

}
