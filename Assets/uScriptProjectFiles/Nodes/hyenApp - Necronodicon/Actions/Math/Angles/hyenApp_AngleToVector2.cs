// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Angles")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Converts an Angle into a Vector2.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Angle To Vector2", "Converts an Angle into a Vector2.")]
public class hyenApp_AngleToVector2 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Angle", "The Angle you want to convert into a Vector2.")] float angle,
		[FriendlyName("Vector2", "The resulting Vector2 direction.")] out Vector2 direction
	) {
		direction = new Vector2(Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle));
		
	}
	
}
