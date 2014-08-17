// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Reverses the order of a Float list.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Reverse List (Float)", "Reverses the order of a Float list.")]
public class hyenApp_ReverseListFloat : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("List", "The List to be reversed.")] float[] list,
		[FriendlyName("Reversed", "The Reversed list.")] out float[] reversed
	) {
		reversed = list;
		Array.Reverse(reversed);
		
	}
	
}
