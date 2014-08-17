// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Navigation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Stop movement of the agent along the current path.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("NavMeshAgent Stop", "Stop movement of the agent along the current path.")]
public class hyenApp_NavMeshAgentStop : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Agent", "The Navigation mesh agent.")] NavMeshAgent agent,
		[FriendlyName("Immediate", "If true, the GameObject is stopped Immediately and not affected by the avoidance system. If false, the NavMeshAgent is controlling the deceleration."), DefaultValue(false)] bool immediate
	){
		agent.Stop(immediate);
		
	}
}
