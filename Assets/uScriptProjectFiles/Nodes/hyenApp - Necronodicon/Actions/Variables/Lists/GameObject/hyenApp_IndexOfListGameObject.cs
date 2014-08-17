// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/GameObject")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Finds the first index of Target in the GameObject List.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Index Of List (GameObject)", "Finds the first index of Target in the GameObject List.")]
public class hyenApp_IndexOfListGameObject : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Target", "The target GameObject to fined its index of in the GameObject List.")] GameObject Target,
		[FriendlyName("GameObject List", "The GameObject List to check.")] ref GameObject[] List,
		[FriendlyName("Index", "The index or position of the Target in the GameObject List.")] out int Index
	) {
		List<GameObject> list = new List<GameObject>(List);
		Index = list.IndexOf(Target);
		
	}
	
}
