// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Navigation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets or updates the destination.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("NavMeshAgent Set Destination", "Sets or updates the destination. This triggers calculation for a new path. \n\nNote that the path may not become available until after a few frames later. While the path is being computed, pathPending will be true.")]
public class hyenApp_NavMeshAgentSetDestination : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Agent", "The Navigation mesh agent.")] ref NavMeshAgent agent,
		[FriendlyName("Destination", "The Destination to navigate towards. Must be a GameObject or Vector3.")] object objectDestination
	){
		Vector3 tempDestination;
		
		if ( objectDestination is GameObject ) {
			GameObject tempGameObject = (GameObject)objectDestination;
			tempDestination = tempGameObject.transform.position;
		
		} else if ( objectDestination is Vector3 ) {
			Vector3 tempVector3 = (Vector3)objectDestination;
			tempDestination = tempVector3;
			
		} else {
			uScriptDebug.Log("[Set Destination (NavMeshAgent)] The Set Destination (NavMeshAgent) node can only take a GameObject or Vector3 for the 'Destination' input socket.", uScriptDebug.Type.Error);
			tempDestination = Vector3.zero;
			
		}
		
		agent.SetDestination(tempDestination);
		
	}
	
}
