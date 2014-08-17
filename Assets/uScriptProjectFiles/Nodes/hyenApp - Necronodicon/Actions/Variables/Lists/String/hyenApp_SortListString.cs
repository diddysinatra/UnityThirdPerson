// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/String")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sorts String lists into ascending or descending order.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Sort List (String)", "Sorts String lists into ascending or descending order.")]
public class hyenApp_SortListString : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("List", "The List to be sorted.")] string[] list,
		[FriendlyName("Ascending", "True = the sorted order will be ascending. False = the sorted order will be descending."), SocketState(false, false), DefaultValue(true)] bool ascending,
		[FriendlyName("Sorted", "The Sorted list.")] out string[] sorted
	) {
		sorted = list;
		
		Array.Sort(sorted);
		
		if(!ascending) {
			Array.Reverse(sorted); //Of course, this is not efficient for large arrays...
		}
		
	}
	
}
