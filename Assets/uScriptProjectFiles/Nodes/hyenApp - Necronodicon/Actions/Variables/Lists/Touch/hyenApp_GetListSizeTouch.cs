// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Variables/Lists/Touch")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the number of items in the list.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get List Size (Touch)", "Gets the number of items in the list.")]
public class hyenApp_GetListSizeTouch : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("List", "The list to operate on.")] Touch[] TouchList,
		[FriendlyName("List Size", "The number of items in the list.")] out int ListCount
	) {
		ListCount = TouchList.Length;
		
	}
	
}
