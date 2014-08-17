// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the active state of Target(s) GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Active", "Sets the active state of Target(s) GameObject, and optionally its children.")]
public class hyenApp_SetActive : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void Active(GameObject[] Target, bool ApplyToChildren ) {
		foreach (GameObject obj in Target) {
			if (ApplyToChildren) {
				obj.SetActive(true);
			} else {
				obj.SetActive(true);
			}
		}
		
	}
	
	public void Inactive(
		[FriendlyName("Target", "The GameObject(s) you wish to set the active state for.")] GameObject[] Target,
		[FriendlyName("Apply To Children", "Specify if the active State should also be assigned to any children GameObjects of the Target."), SocketState(false, false), DefaultValue(false)] bool ApplyToChildren
	) {
		foreach (GameObject obj in Target) {
			if (ApplyToChildren) {
				obj.SetActive(false);
			} else {
				obj.SetActive(false);
			}
		}
		
	}

}
