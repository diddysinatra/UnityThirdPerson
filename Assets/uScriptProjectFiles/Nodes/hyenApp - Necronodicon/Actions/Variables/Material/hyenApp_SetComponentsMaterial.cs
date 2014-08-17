// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Creates and then sets the main components of a temporary Shader & Material.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Components (Material)", "Creates and then sets the main components of a temporary Shader & Material inside your graph. \n\nAfter creating the material, use Set Color, Set Texture, Set Float, Set Vector, Set Matrix nodes to populate the shader property values.")]
public class hyenApp_SetComponentsMaterial : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Source Material", "Create a temporary Material by copying the shader and all properties from the Source Material."), SocketState(false, false)] Material sourceMaterial,
		[FriendlyName("Shader", "Create a temporary Material from a Shader.")] Shader shader,
		[FriendlyName("Source String", "Create a temporary Material from a shader source String."), SocketState(false, false)] string sourceString,
		[FriendlyName("Color", "The main material's color."), SocketState(false, false)] Color color,
		[FriendlyName("Texture", "The main material's texture."), SocketState(false, false)] Texture texture,
		[FriendlyName("Texture2D", "The main material's texture as Texture2D."), SocketState(false, false)] Texture2D texture2D,
		[FriendlyName("Texture Offset", "The texture offset of the main texture."), SocketState(false, false)] Vector2 textureOffset,
		[FriendlyName("Texture Scale", "The texture scale of the main texture."), SocketState(false, false)] Vector2 textureScale,
		[FriendlyName("Pass Count", "How many passes are in this material (Read Only)."), SocketState(false, false)] out int passCount,
		[FriendlyName("Render Queue", "Render queue of this material. \n\nBy default materials use render queue of the shader it uses. You can override the render queue used using this variable. Note that once render queue is set on the material, it stays at that value, even if shader is later changed to be different. \n\nRender queue number should be positive to work properly."), SocketState(false, false)] int renderQueue,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Material targetMaterial
	) {
		if(null != sourceMaterial) {
			targetMaterial = new Material(sourceMaterial);
		} else if(null != shader) {
			targetMaterial = new Material(shader);
		} else if(null != sourceString) {
			targetMaterial = new Material(sourceString);
		} else {
			targetMaterial = new Material(Shader.Find("Diffuse"));
		}
		
		if(color != targetMaterial.color) {
			targetMaterial.color = color;
		}
		
		if(null != texture) {
			targetMaterial.mainTexture = texture;
		} else if(null != texture2D) {
			targetMaterial.mainTexture = texture2D;
		}
		
		if(textureOffset != targetMaterial.mainTextureOffset) {
			targetMaterial.mainTextureOffset = textureOffset;
		}
		
		if(textureScale != targetMaterial.mainTextureScale) {
			targetMaterial.mainTextureScale = textureScale;
		}
		
		passCount = targetMaterial.passCount;
		
		if(renderQueue != targetMaterial.renderQueue && renderQueue >= 0) {
			targetMaterial.renderQueue = renderQueue;
		}
		
	}
	
}
