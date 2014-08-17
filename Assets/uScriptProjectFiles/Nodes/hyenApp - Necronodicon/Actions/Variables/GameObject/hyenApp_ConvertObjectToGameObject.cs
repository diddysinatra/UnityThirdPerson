// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/GameObject")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Converts an Object variable into a GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Convert Object To GameObject", "Converts an Object variable into a GameObject.")]
public class hyenApp_ConvertObjectToGameObject : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target variable to be converted.")] object Target,
		[FriendlyName("GameObject", "The Target variable represented as a GameObject.")] out GameObject GameObjectValue
	) {
		if (Target is GameObject) {
			GameObjectValue = (GameObject)Target;
		} else if(Target is Component) {
			Component component = (Component)Target;
			GameObjectValue = component.gameObject;
		} else {
			uScriptDebug.Log("[Convert Object To GameObject] the Target socket contains null or unexspected data. Please check your specified object be sure that it is not null.", uScriptDebug.Type.Warning);
			GameObjectValue = new GameObject();
		}
		
	}

}