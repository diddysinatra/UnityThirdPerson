// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Texture2D")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Actually apply all previous 'Set Pixel Color' and 'Set Pixels Color' changes.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Apply Changes (Texture2D)", "Actually apply all previous 'Set Pixel Color (Texture2D)' and 'Set Pixels Color (Texture2D)' node changes. \n\nThis is a potentially expensive operation, so you'll want to change as many pixels as possible between Apply calls. \n\nThe texture has to have 'Is Readable' flag set in the import settings.")]
public class hyenApp_ApplyTexture2D : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Texture2D", "The Texture2D to apply all previous 'Set Pixel Color' and 'Set Pixels Color' changes to.")] Texture2D[] texture2Ds,
		[FriendlyName("Update Mipmaps", "If Update Mipmaps is true, the mipmap levels are recalculated as well, using the base level as a source. Usually you want to use true in all cases except when you've modified the mip levels yourself using SetPixels."), SocketState(false, false), DefaultValue(true)] bool updateMipmaps,
		[FriendlyName("Make No Longer Readable", "If Make No Longer Readable is true, texture will be marked as no longer readable and memory will be freed after uploading to GPU."), SocketState(false, false), DefaultValue(false)] bool makeNoLongerReadable
	) {
		try {
			foreach (Texture2D texture2D in texture2Ds) {
				texture2D.Apply(updateMipmaps, makeNoLongerReadable);
			}
		} catch (System.Exception e) {
			uScriptDebug.Log("Apply Changes (Texture2D) node Error output: " + e.ToString(), uScriptDebug.Type.Error);
		}
		
	}
	
}
