// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/NavMeshAgent")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip( "Sets the components of a NavMeshAgent.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Components (NavMeshAgent)", "Sets the components of a NavMeshAgent.")]
public class hyenApp_SetComponentsNavMeshAgent : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Agent", "The NavMeshAgent agent.")] ref NavMeshAgent agent,
		[FriendlyName("Destination", "The Destination to navigate towards.")] Vector3 destination
	){
		agent.destination = destination;
		
	}
	
}
