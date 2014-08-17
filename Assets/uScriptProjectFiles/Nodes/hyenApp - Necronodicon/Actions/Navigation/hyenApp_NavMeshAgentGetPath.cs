// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Navigation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets a copy of the current path.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("NavMeshAgent Get Path", "Gets a copy of the navigation mesh agent's current NavMeshPath, also gets the path Corners and Status.")]
public class hyenApp_NavMeshAgentGetPath : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Agent", "The NavMeshAgent you wish to get the current path from.")] NavMeshAgent agent,
		[FriendlyName("Path", "The agent's current NavMeshPath.")] out NavMeshPath path,
		[FriendlyName("Corners", "Corner points of path. (Read Only)"), SocketState(false, false)] out Vector3[] corners,
		[FriendlyName("Status", "Status of the path. (Read Only)"), SocketState(false, false)] out NavMeshPathStatus status
	) {
		path = agent.path;
		corners = path.corners;
		status = path.status;
		
	}
	
}
