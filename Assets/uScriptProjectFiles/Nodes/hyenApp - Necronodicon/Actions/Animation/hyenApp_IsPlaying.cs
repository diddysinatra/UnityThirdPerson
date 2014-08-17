// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Animation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Is the Target GameObject playing any animations?")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Is Playing", "Is the Target GameObject playing any animations?")]
public class hyenApp_IsPlaying : uScriptLogic {

	private bool m_PlayingValue = false;

	public bool True { get { return m_PlayingValue; } }
	public bool False { get { return !m_PlayingValue; } }

	public void In(
		[FriendlyName("Target", "The Target GameObject to check its Animation component isPlaying property.")] GameObject target
	) {
		m_PlayingValue = target.animation.isPlaying;
		
	}
	
}
