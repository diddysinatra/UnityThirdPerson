// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Animation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Is animation Name playing on Target GameObject?")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Is Animation Playing", "Is animation Name playing on Target GameObject?")]
public class hyenApp_IsAnimationPlaying : uScriptLogic {

	private bool m_PlayingValue = false;

	public bool True { get { return m_PlayingValue; } }
	public bool False { get { return !m_PlayingValue; } }

	public void In(
		[FriendlyName("Target", "The Target GameObject to check its Animation component to see if animation Name is playing.")] GameObject target,
		[FriendlyName("Name", "The animation Name to see whether its playing on the Target GameObject.")] string name
	) {
		m_PlayingValue = target.animation.IsPlaying( name );
		
	}
	
}
