// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/Touch")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Access different elements in a Touch List. Can access first, last, random or by index.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Access List (Touch)", "Access the contents of a list. May return the first or last item, a random item, or the item at a specific index.")]
public class hyenApp_AccessListTouch : uScriptLogic {

	public bool Out { get { return true; } }

	public void First(Touch[] List, int Index, out Touch Value) {
		Value = List[0];
	}

	public void Last(Touch[] List, int Index, out Touch Value) {
		Value = List[List.Length - 1];
	}

	public void Random(Touch[] List, int Index, out Touch Value) {
		int index = UnityEngine.Random.Range(0, List.Length);
		Value = List[index];
	}

	[FriendlyName("At Index")]
	public void AtIndex(
		[FriendlyName("List", "The list to operate on.")] Touch[] List,
		[FriendlyName("Index", "The index or position of the item to return. If the list contains 5 items, the valid range is 0-4, where 0 is the first item. (this parameter is only used with the At Index input).")] int Index,
		[FriendlyName("Selected", "The selected variable.")] out Touch Value
	) {
		bool outOfRange = false;
		
		if (Index < 0 || Index >= List.Length) { outOfRange = true; }

		if (outOfRange) {
			uScriptDebug.Log("[Access List (Touch)] You are trying to use an index number that is out of range for this list variable. Index 0 was returned instead.", uScriptDebug.Type.Error);
			Value = List[0];
		} else {
			Value = List[Index];
		}
		
	}
	
}
