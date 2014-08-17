// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/Int")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sorts Int lists into ascending or descending order.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Sort List (Int)", "Sorts Int lists into ascending or descending order.")]
public class hyenApp_SortListInt : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("List", "The List to be sorted.")] int[] list,
		[FriendlyName("Ascending", "True = the sorted order will be ascending. False = the sorted order will be descending."), SocketState(false, false), DefaultValue(true)] bool ascending,
		[FriendlyName("Sorted", "The Sorted list.")] out int[] sorted
	) {
		sorted = list;
		
		if(ascending) {
			Array.Sort(sorted);
		} else {
			Array.Sort(sorted, delegate(int a, int b) { return b - a; }); //normal compare is a - b
		}
		
	}
	
}
