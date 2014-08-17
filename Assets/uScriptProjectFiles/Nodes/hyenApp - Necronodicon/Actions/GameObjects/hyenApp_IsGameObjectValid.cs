// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Determines wether or not a GameObject is valid.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Is GameObject Valid", "Determines wether or not a GameObject is valid.")]
public class hyenApp_IsGameObjectValid : uScriptLogic {

	private bool m_IsValid;
	
	public bool Out { get { return true; } }
	
	public bool Valid { get { return m_IsValid; } }
	
	public bool Invalid { get { return !m_IsValid; } }
	
	public void In(
		[FriendlyName("Target", "GameObject to validate.")] GameObject Target
	) {
		if (!Target) {
			m_IsValid = false;
		} else {
			m_IsValid = true;
		}
		
	}
	
}