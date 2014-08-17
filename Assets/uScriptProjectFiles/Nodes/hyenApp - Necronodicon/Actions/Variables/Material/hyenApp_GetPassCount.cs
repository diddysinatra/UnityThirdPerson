// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get how many passes are in this material.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Pass Count (Material)", "Get how many passes are in this material (Read Only).")]
public class hyenApp_GetPassCount : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material's to get the Pass Count from.")] Material material,
		[FriendlyName("Pass Count", "How many passes are in this material.")] out int passCount
	) {
		passCount = material.passCount;
		
	}
	
}
