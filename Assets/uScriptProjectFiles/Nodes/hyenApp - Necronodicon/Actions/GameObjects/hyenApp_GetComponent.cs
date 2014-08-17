// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns the component with name type if the game object has one attached, null if it doesn't.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.hyenapp.com")]

[FriendlyName("Get Component", "Returns the component with Name type if the game object has one attached, null if it doesn't.")]
public class hyenApp_GetComponent : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "GameObject which contains the component.")] GameObject Target,
		[FriendlyName("Name", "The Name type of the component you want to get.")] string Name,
		[FriendlyName("Component", "The Component.")] out Component outComponent
	) {
		outComponent = Target.GetComponent( Name );
		
	}

}
