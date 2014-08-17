// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/2D Lists/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get the number of things currently in a 2D List.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get 2D List Size (Float)", "Get the number of things currently in a 2D List.")]
public class hyenApp_Get2DListSizeFloat : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The 2D List to get the sizes from.")] float[,] list,
		[FriendlyName("First Size", "The first size of the 2D List specified.")] out int firstSize,
		[FriendlyName("Second Size", "The second size of the 2D List specified.")] out int secondSize
	) {
		firstSize = list.GetLength(0);
		secondSize = list.GetLength(1);
		
	}
	
}
