// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Variables/Lists/Touch")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Converts an Object variable into a List of touchs.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Convert Object To List (Touch)", "Converts an Object variable into a List of touchs.")]
public class hyenApp_ConvertObjectToListTouch : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target variable to be converted.")] object Target,
		[FriendlyName("Touch List", "The Target variable represented as a Touch list.")] out Touch[] TouchList,
		[FriendlyName("List Size", "The number of items in the list after the conversion has taken place.")] out int ListCount
	) {
		TouchList = new Touch[0];
		ListCount = 0;
		
		if (Target is Touch[]) {
			TouchList = (Touch[])Target;
			ListCount = TouchList.Length;
		} else {
			uScriptDebug.Log("[Convert Object To List (Touch)] type of"+ Target.GetType() +" not supported in Target.", uScriptDebug.Type.Error);
		}
		
	}
	
}
