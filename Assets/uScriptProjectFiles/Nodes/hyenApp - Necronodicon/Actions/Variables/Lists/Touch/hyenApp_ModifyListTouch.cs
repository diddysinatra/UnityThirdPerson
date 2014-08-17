// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Variables/Lists/Touch")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Adds/removes Touch from a Touch List. Can also empty the Touch List.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Modify List (Touch)", "Modify a list by adding/removing the specified variable(s), or by emptying it entirely.")]
public class hyenApp_ModifyListTouch : uScriptLogic {

	public bool Out { get { return true; } }

	[FriendlyName("Add To List")]
	public void AddToList(Touch[] Target, ref Touch[] List, out int ListCount) {
		List<Touch> list = new List<Touch>(List);

		foreach (Touch item in Target) {
			list.Add(item);
		}
		
		List = list.ToArray();
		ListCount = List.Length;
	}

	[FriendlyName("Remove From List")]
	public void RemoveFromList(Touch[] Target, ref Touch[] List, out int ListCount) {
		List<Touch> list = new List<Touch>(List);

		foreach (Touch item in Target) {
			if (list.Contains(item)) {
				list.Remove(item);
			}
		}
		
		List = list.ToArray();
		ListCount = List.Length;
	}

	[FriendlyName("Empty List")]
	public void EmptyList(
		[FriendlyName("Target", "The Target variable(s) to add or remove from the list.")] Touch[] Target,
		[FriendlyName("List", "The list to modify.")] ref Touch[] List,
		[FriendlyName("List Size", "The remaining number of items in the list after the modification has taken place.")] out int ListCount
	) {
		List = new Touch[] {};
		ListCount = 0;
	}
	
}
