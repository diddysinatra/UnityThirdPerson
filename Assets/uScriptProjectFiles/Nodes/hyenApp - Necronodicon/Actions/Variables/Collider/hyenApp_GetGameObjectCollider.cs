// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Collider")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the GameObject this Collider is attached to.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get GameObject (Collider)", "Gets the GameObject this Collider is attached to. (A Collider component is always attached to a game object.)")]
public class hyenApp_GetGameObjectCollider : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Collider", "The target Collider.")] Collider collider,
		[FriendlyName("GameObject", "The GameObject this Collider is attached to.")] out GameObject gameObject
	) {
		gameObject = collider.gameObject;
		
	}
	
}
