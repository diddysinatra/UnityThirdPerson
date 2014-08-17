// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/String")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Finds the first index of Target in the String List.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Index Of List (String)", "Finds the first index of Target in the String List.")]
public class hyenApp_IndexOfListString : uScriptLogic {
	
	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Target", "The target string to fined its index of in the String List.")] string Target,
		[FriendlyName("String List", "The String List to check.")] ref string[] List,
		[FriendlyName("Index", "The index or position of the Target in the String List.")] out int Index
	) {
		List<string> list = new List<string>(List);
		Index = list.IndexOf(Target);
		
	}
	
}
