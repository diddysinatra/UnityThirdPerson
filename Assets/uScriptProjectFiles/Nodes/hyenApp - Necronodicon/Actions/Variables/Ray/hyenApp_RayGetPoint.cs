// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Ray")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets a point at distance along the ray.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Ray Get Point", "Gets a point at distance along the ray.")]
public class hyenApp_RayGetPoint : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Input Ray", "The input ray to get a point from.")] Ray InputRay,
		[FriendlyName("Distance", "The Distance in units from the origin of the Ray you with the get a point from.")] float Distance,
		[FriendlyName("Point", "The Vector3 Point along the Ray at the specified Distance from the rays origin.")] out Vector3 Point
	) {
		Point = InputRay.GetPoint(Distance);
		
	}
	
}
