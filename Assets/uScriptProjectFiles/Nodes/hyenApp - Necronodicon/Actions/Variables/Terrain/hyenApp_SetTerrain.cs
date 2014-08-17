// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Terrain")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a Terrain variable using the value of another Terrain variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Terrain", "Sets the value of a Terrain variable using the value of another Terrain variable.")]
public class hyenApp_SetTerrain : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Terrain Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Terrain Target
	) {
		Target = Value;
		
	}
	
}
