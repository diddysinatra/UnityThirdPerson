// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/String")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Reverses the order of a String list.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Reverse List (String)", "Reverses the order of a String list.")]
public class hyenApp_ReverseListString : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("List", "The List to be reversed.")] string[] list,
		[FriendlyName("Reversed", "The Reversed list.")] out string[] reversed
	) {
		reversed = list;
		Array.Reverse(reversed);
		
	}
	
}
