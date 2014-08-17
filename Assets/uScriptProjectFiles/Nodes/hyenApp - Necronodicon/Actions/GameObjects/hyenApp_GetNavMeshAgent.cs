// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns the NavMeshAgent component if the target GameGbject has one attached.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.hyenapp.com")]

[FriendlyName("Get NavMeshAgent", "Returns the NavMeshAgent component if the target GameGbject has one attached, null if it doesn't.")]
public class hyenApp_GetNavMeshAgent : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "GameObject which contains the NavMeshAgent component.")] GameObject target,
		[FriendlyName("NavMeshAgent", "The NavMeshAgent from the target GameObject.")] out NavMeshAgent agent
	) {
		agent = target.GetComponent<NavMeshAgent>();
		
	}
	
}
