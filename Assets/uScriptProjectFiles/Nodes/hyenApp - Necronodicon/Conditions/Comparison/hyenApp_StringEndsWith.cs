// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Determines if the target string ends with the specified text.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("String Ends With", "Determines if the target string ends with the specified text.")]
public class hyenApp_StringEndsWith : uScriptLogic {
	
	private bool m_EndsWithValue = false;
	
	public bool True { get { return m_EndsWithValue; } }

	public bool False { get { return !m_EndsWithValue; } }

	public void In(
		[FriendlyName("Target", "The target string you wish to check.")] string Target,
		[FriendlyName("Value", "The text you want to search for in the Target string.")] string Value
	){
		m_EndsWithValue = Target.EndsWith(Value);
		
	}
	
}
