// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Ray")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns a nicely formatted string for the input ray.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Ray To String", "Returns a nicely formatted string for the input ray.")]
public class hyenApp_RayToString : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Input Ray", "The input ray to return a string for.")] Ray InputRay,
		[FriendlyName("Format", ""), DefaultValue(""), SocketState(false, false)] string Format,
		[FriendlyName("String", "The return string.")] out string toString
	) {
		if (Format != "") {
			toString = InputRay.ToString(Format);
			
		} else {
			toString = InputRay.ToString();
			
		}
		
	}
	
}
