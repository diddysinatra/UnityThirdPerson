// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Switches")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Is the Target int Odd or Even.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Odd or Even Switch", "Is the Target int Odd or Even.")]
public class hyenApp_OddEvenSwitch : uScriptLogic {

	private bool m_IsOdd = true;
	
	[FriendlyName("Odd")] public bool False { get { return m_IsOdd; } }
	[FriendlyName("Even")] public bool True { get { return !m_IsOdd; } }
	
	public void In(
		[FriendlyName("Output To Use", "The output switch to use.")] int currentOutput
	) {
		if (currentOutput % 2 == 0) {
			m_IsOdd = false;
		} else {
			m_IsOdd = true;
		}

	}
	
}
