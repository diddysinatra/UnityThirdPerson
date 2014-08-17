// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/LightmapData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets a LightmapData to the defined value.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set LightmapData", "Sets a LightmapData to the defined value.")]
public class hyenApp_SetLightmapData : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] LightmapData Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out LightmapData Target
	) {
		Target = Value;
		
	}
	
}