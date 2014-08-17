// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Gizmos")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the color for the gizmos that will be drawn next.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Color (Gizmos)", "Sets the color for the gizmos that will be drawn next.")]
public class hyenApp_GizmosSetColor : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Color", "The color you wish to use for the gizmos that will be drawn next.")] Color color
	) {
		Gizmos.color = color;
		
	}
	
}
