// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Compares two RuntimePlatform variables and outputs accordingly.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Compare RuntimePlatform", "Compares two RuntimePlatform variables and outputs accordingly.")]
public class hyenApp_CompareRuntimePlatform : uScriptLogic {

	private bool m_CompareValue = false;

	public bool Same { get { return m_CompareValue; } }
	public bool Different { get { return !m_CompareValue; } }

	public void In(
		[FriendlyName("A", "First value to compare.")] RuntimePlatform A,
		[FriendlyName("B", "Second value to compare.")] RuntimePlatform B
	) {
		m_CompareValue = A == B;
		
	}
	
}