// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System;

[NodePath("Actions/Variables/Lists/LightmapData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets a LightmapData List to the defined value.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set List (LightmapData)", "Sets a LightmapData List to the defined value.")]
public class hyenApp_SetListLightmapData : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] LightmapData[] Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out LightmapData[] Target
	) {
		Target = Value;
		
	}
	
}
