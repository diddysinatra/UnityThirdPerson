// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/NavMeshAgent")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the value of a NavMeshAgent variable using the value of another NavMeshAgent variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set NavMeshAgent", "Sets the value of a NavMeshAgent variable using the value of another NavMeshAgent variable.")]
public class hyenApp_SetNavMeshAgent : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Value", "The variable you wish to use to set the target's value.")] NavMeshAgent Value,
		[FriendlyName("Target", "The Target variable you wish to set.")] out NavMeshAgent Target
	) {
		Target = Value;
		
	}
	
}
