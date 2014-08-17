// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/2D Lists/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Replaces a value in the 2D List with the new value at the specified indexs.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Replace Value At Index In 2D List (Float)", "Replaces a value in the 2D List with the new value at the specified indexs.")]
public class hyenApp_ReplaceValueAtIndexIn2DListFloat : uScriptLogic {

	public bool Out { get { return true; } }
   
	public void In(
		[FriendlyName("Target 2D List", "The 2D List to check.")] float[,] TargetList,
		[FriendlyName("First Index", "The first index of the item to replace.")] int firstIndex,
		[FriendlyName("Second Index", "The second index of the item to replace.")] int secondIndex,
		[FriendlyName("New Value", "The new value to replace at the index.")] float NewValue,
		[FriendlyName("Modified 2D List", "The 2D List after the values have been changed.")] out float[,] ModifiedList
	) {
		if (TargetList.GetLength(0) > firstIndex && TargetList.GetLength(1) > secondIndex) {
			TargetList[firstIndex, secondIndex] = NewValue;
		}

		ModifiedList = TargetList;
		
	}
	
}
