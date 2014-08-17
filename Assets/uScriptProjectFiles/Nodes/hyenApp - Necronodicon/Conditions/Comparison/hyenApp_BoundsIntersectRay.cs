// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Does ray intersect this bounding box?")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Bounds Intersects Ray", "Does ray intersect this bounding box?")]
public class hyenApp_BoundsIntersectRay : uScriptLogic {

	private bool m_IntersectsRay = false;

	[FriendlyName("True")] public bool True { get { return m_IntersectsRay; } }
	[FriendlyName("False")] public bool False { get { return !m_IntersectsRay; } }

	public void In(
		[FriendlyName("Bounds", "The Bounds you wish to check.")]  Bounds bounds,
		[FriendlyName("Ray", "The Point you want to check for in the Bounds.")] Ray ray,
		[FriendlyName("Distance", "When IntersectRay returns true distance will be the distance to the ray's origin."), SocketState(false, false)] out float distance
	) {
		float d = 0.0f;
		m_IntersectsRay = bounds.IntersectRay(ray, out d);
		distance = d;
	}
	
}
