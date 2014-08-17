// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Gizmos")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Draw an icon at a position in the scene view.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Draw Icon (Gizmos)", "Draw an icon at a position in the scene view. \n\nDrawIcon can be used to allow important objects in your game to be selected quickly.")]
public class hyenApp_GizmosDrawIcon : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Position", "The center position of the icon. Must be a GameObject or Vector3.")] object objectPosition,
		[FriendlyName("Name", "The image file Name for the icon. The image file should be placed in the Assets/Gizmos folder.")] string name,
		[FriendlyName("Allow Scaling", "Determines if the icon is allowed to be scaled."), DefaultValue(true), SocketState(false, false)] bool allowScaling
	) {
		Vector3 position;
		
		if ( objectPosition is GameObject ) {
			GameObject tempGameObject = (GameObject)objectPosition;
			position = tempGameObject.transform.position;
		
		} else if ( objectPosition is Vector3 ) {
			Vector3 tempVector3 = (Vector3)objectPosition;
			position = tempVector3;
			
		} else {
			uScriptDebug.Log("[Draw Icon (Gizmos)] The Draw Icon (Gizmos) node can only take a GameObject or Vector3 for the 'Position' input socket.", uScriptDebug.Type.Error);
			position = Vector3.zero;
			
		}
		
		Gizmos.DrawIcon(position, name, allowScaling);
		
	}
	
}
