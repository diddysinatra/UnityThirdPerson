// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/LayerMask")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a LayerMask variable using the value of another LayerMask variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set LayerMask", "Sets the value of a LayerMask variable using the value of another LayerMask variable.")]
public class hyenApp_SetLayerMask : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] LayerMask Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out LayerMask Target
	) {
		Target = Value;
		
	}
	
}
