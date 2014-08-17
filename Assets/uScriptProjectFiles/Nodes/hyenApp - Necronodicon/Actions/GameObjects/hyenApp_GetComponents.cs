// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns all components of Name type in the GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.hyenapp.com")]

[FriendlyName("Get Components", "Returns all components of Name type in the GameObject.")]
public class hyenApp_GetComponents : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "GameObject which contains the component.")] GameObject target,
		[FriendlyName("Name", "The Name type of the component you want to get.")] string typeName,
		[FriendlyName("Components", "The Components.")] out Component[] outComponents
	) {
		outComponents = target.GetComponents( typeName.GetType() );
		
	}

}
