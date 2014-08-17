// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Is point contained in the bounding box?")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Bounds Contains", "Determines if the Bounds contains the specified Point?")]
public class hyenApp_BoundsContains : uScriptLogic {

	private bool m_ContainsPoint = false;

	[FriendlyName("True")] public bool True { get { return m_ContainsPoint; } }
	[FriendlyName("False")] public bool False { get { return !m_ContainsPoint; } }

	public void In(
		[FriendlyName("Bounds", "The Bounds you wish to check.")]  Bounds bounds,
		[FriendlyName("Point", "The Point you want to check for in the Bounds.")] Vector3 point
	) {
		m_ContainsPoint = bounds.Contains(point);
		
	}
	
}
