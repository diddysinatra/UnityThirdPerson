// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System;

[NodePath("Actions/Variables/Lists/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets a Material List to the defined value.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set List (Material)", "Sets a Material List to the defined value.")]
public class hyenApp_SetListMaterial : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] Material[] Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out Material[] Target
	) {
		Target = Value;
		
	}
	
}
