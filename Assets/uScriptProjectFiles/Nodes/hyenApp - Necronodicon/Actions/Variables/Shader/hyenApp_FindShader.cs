// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Shader")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Finds a shader with the given name.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Find Shader", "Finds a shader with the given name. \n\nFind Shader can be used to switch to another shader without having to keep a reference to the shader. \n\nWhen building a player, a shader will only be included if it is assigned to a material that is used in any scene or if the shader is placed in a 'Resources' folder.")]
public class hyenApp_FindShader : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Name", "The Name is the name you can see in the shader popup of any material. Common names are: 'Diffuse', 'Bumped Diffuse', 'VertexLit', 'Transparent/Diffuse' etc."), DefaultValue("Diffuse")] string name,
		[FriendlyName("Target", "The Target shader.")] out Shader targetShader
	) {
		targetShader = Shader.Find(name);
		
	}
	
}
