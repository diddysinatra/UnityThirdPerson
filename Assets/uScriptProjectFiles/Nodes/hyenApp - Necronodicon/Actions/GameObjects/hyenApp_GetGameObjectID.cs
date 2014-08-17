// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip( "Gets the unique ID of a GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get GameObject ID", "Returns the unique instance ID of the Target GameObject.")]
public class hyenApp_GetGameObjectID : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The GameObject.")] GameObject gameObject,
		[FriendlyName("ID", "The returned unique ID of the GameObject.")] out int id
	) {
		id = gameObject.GetInstanceID();
		
	}
	
}
