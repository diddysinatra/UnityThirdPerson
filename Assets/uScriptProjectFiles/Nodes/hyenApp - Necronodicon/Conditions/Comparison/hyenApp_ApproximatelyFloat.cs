// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Compares two floating point values if they are similar.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Approximately Float", "Compares two floating point values if they are similar. \n\nDue to floating point imprecision it is not recommended to compare floats using the equal operator. eg. 1.0 == 10.0 / 10.0 might not return true.")]
public class hyenApp_ApproximatelyFloat : uScriptLogic {

	private bool m_Boolean = false;

	[FriendlyName("True")] public bool True { get { return m_Boolean; } }
	[FriendlyName("False")] public bool False { get { return !m_Boolean; } }

	public void In(
		[FriendlyName("A", "The first float you wish to compare.")]  float a,
		[FriendlyName("B", "The Second float you wish to compare.")] float b
	) {
		m_Boolean = Mathf.Approximately(a, b);
		
	}
	
}
