// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Variables/Lists/LightmapData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Adds/removes LightmapData from a LightmapData List. Can also empty the LightmapData List.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Modify List (LightmapData)", "Modify a list by adding/removing the specified variable(s), or by emptying it entirely.")]
public class hyenApp_ModifyListLightmapData : uScriptLogic {

	public bool Out { get { return true; } }

	[FriendlyName("Add To List")]
	public void AddToList(LightmapData[] Target, ref LightmapData[] List, out int ListCount) {
		List<LightmapData> list = new List<LightmapData>(List);

		foreach (LightmapData item in Target) {
			list.Add(item);
		}
		
		List = list.ToArray();
		ListCount = List.Length;
	}

	[FriendlyName("Remove From List")]
	public void RemoveFromList(LightmapData[] Target, ref LightmapData[] List, out int ListCount) {
		List<LightmapData> list = new List<LightmapData>(List);

		foreach (LightmapData item in Target) {
			if (list.Contains(item)) {
				list.Remove(item);
			}
		}
		
		List = list.ToArray();
		ListCount = List.Length;
	}

	[FriendlyName("Empty List")]
	public void EmptyList(
		[FriendlyName("Target", "The Target variable(s) to add or remove from the list.")] LightmapData[] Target,
		[FriendlyName("List", "The list to modify.")] ref LightmapData[] List,
		[FriendlyName("List Size", "The remaining number of items in the list after the modification has taken place.")] out int ListCount
	) {
		List = new LightmapData[] {};
		ListCount = 0;
	}
	
}