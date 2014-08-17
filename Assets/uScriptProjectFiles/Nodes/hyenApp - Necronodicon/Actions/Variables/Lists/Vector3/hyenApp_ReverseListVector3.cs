// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/Vector3")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Reverses the order of a Vector3 list.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Reverse List (Vector3)", "Reverses the order of a Vector3 list.")]
public class hyenApp_ReverseListVector3 : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("List", "The List to be reversed.")] Vector3[] list,
		[FriendlyName("Reversed", "The Reversed list.")] out Vector3[] reversed
	) {
		reversed = list;
		Array.Reverse(reversed);
		
	}
	
}
