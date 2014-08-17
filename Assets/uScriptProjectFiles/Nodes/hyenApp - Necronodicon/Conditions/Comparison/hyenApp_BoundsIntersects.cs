// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Does another bounding box intersect with this bounding box?")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Bounds Intersects", "Does another bounding box intersect with this bounding box?")]
public class hyenApp_BoundsIntersects : uScriptLogic {

	private bool m_Intersects = false;

	[FriendlyName("True")] public bool True { get { return m_Intersects; } }
	[FriendlyName("False")] public bool False { get { return !m_Intersects; } }

	public void In(
		[FriendlyName("A", "The first Bounds you wish to check.")]  Bounds a,
		[FriendlyName("B", "The Second Bounds you wish to check.")] Bounds b
	) {
		m_Intersects = a.Intersects(b);
		
	}
	
}
