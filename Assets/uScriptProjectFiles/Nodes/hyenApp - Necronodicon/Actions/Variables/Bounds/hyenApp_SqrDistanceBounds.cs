// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Bounds")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("The smallest squared distance between the Point and the Target bounding box.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Sqr Distance (Bounds)", "The smallest squared distance between the Point and the Target bounding box.")]
public class hyenApp_SqrDistanceBounds : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target Bounds variable.")] Bounds Target,
		[FriendlyName("Point", "The Point Vector3 variable.")] Vector3 Point,
		[FriendlyName("Distance", "The smallest squared distance between the Point and the Target bounding box.")] out float Distance
	) {
		Distance = Target.SqrDistance(Point);
		
	}
	
}
