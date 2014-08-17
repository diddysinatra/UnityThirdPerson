// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/Int")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Reverses the order of a Int list.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Reverse List (Int)", "Reverses the order of a Int list.")]
public class hyenApp_ReverseListInt : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("List", "The List to be reversed.")] int[] list,
		[FriendlyName("Reversed", "The Reversed list.")] out int[] reversed
	) {
		reversed = list;
		Array.Reverse(reversed);
		
	}
	
}
