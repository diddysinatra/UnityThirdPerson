// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Modifies the main components of a Shader & Material.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Modify Material", "Modifies the main components of a Shader & Material inside your graph.")]
public class hyenApp_ModifyMaterial : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Material", "The Material variable you wish to Modify.")] ref Material refMaterial,
		[FriendlyName("Color", "The main material's color.")] Color color,
		[FriendlyName("Texture", "The main material's texture."), SocketState(false, false)] Texture texture,
		[FriendlyName("Texture2D", "The main material's texture as Texture2D.")] Texture2D texture2D,
		[FriendlyName("Texture Offset", "The texture offset of the main texture."), SocketState(false, false)] Vector2 textureOffset,
		[FriendlyName("Texture Scale", "The texture scale of the main texture."), SocketState(false, false)] Vector2 textureScale,
		[FriendlyName("Pass Count", "How many passes are in this material (Read Only)."), SocketState(false, false)] out int passCount,
		[FriendlyName("Render Queue", "Render queue of this material. \n\nBy default materials use render queue of the shader it uses. You can override the render queue used using this variable. Note that once render queue is set on the material, it stays at that value, even if shader is later changed to be different. \n\nRender queue number should be positive to work properly."), SocketState(false, false)] int renderQueue
	) {
		if(color != refMaterial.color) {
			refMaterial.color = color;
		}
		
		if(null != texture) {
			refMaterial.mainTexture = texture;
		} else if(null != texture2D) {
			refMaterial.mainTexture = texture2D;
		}
		
		if(textureOffset != refMaterial.mainTextureOffset) {
			refMaterial.mainTextureOffset = textureOffset;
		}
		
		if(textureScale != refMaterial.mainTextureScale) {
			refMaterial.mainTextureScale = textureScale;
		}
		
		passCount = refMaterial.passCount;
		
		if(renderQueue != refMaterial.renderQueue && renderQueue >= 0) {
			refMaterial.renderQueue = renderQueue;
		}
		
	}
	
}
