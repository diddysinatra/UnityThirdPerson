// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/TerrainData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a TerrainData variable using the value of another TerrainData variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set TerrainData", "Sets the value of a TerrainData variable using the value of another TerrainData variable.")]
public class hyenApp_SetTerrainData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] TerrainData Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out TerrainData Target
	) {
		Target = Value;
		
	}
	
}
