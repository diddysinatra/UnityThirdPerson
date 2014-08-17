// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Material.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (Material)", "Gets the components of a Material.")]
public class hyenApp_GetComponentsMaterial : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Input Material", "The input Material to get components of.")] Material inputMaterial,
		[FriendlyName("Shader", "The shader used by the material."), SocketState(false, false)] out Shader shader,
		[FriendlyName("Color", "The main material's color.")] out Color color,
		[FriendlyName("Texture", "The main material's texture."), SocketState(false, false)] out Texture texture,
		[FriendlyName("Texture2D", "The main material's texture as Texture2D.")] out Texture2D texture2D,
		[FriendlyName("Texture Offset", "The texture offset of the main texture."), SocketState(false, false)] out Vector2 textureOffset,
		[FriendlyName("Texture Scale", "The texture scale of the main texture."), SocketState(false, false)] out Vector2 textureScale,
		[FriendlyName("Pass Count", "How many passes are in this material (Read Only)."), SocketState(false, false)] out int passCount,
		[FriendlyName("Render Queue", "Render queue of this material."), SocketState(false, false)] out int renderQueue
	) {
		shader = inputMaterial.shader;
		color = inputMaterial.color;
		texture = inputMaterial.mainTexture;
		texture2D = inputMaterial.mainTexture as Texture2D;
		textureOffset = inputMaterial.mainTextureOffset;
		textureScale = inputMaterial.mainTextureScale;
		passCount = inputMaterial.passCount;
		renderQueue = inputMaterial.renderQueue;
	}
	
}
