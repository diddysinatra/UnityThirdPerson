// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Gizmos")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Draws a Ray, or a line starting at From to From + Direction.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Draw Ray (Gizmos)", "Draws a Ray, or a line starting at From to From + Direction.")]
public class hyenApp_GizmosDrawRay : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		//[FriendlyName("Ray", "The starting position of the line. Must be a GameObject or Vector3."), SocketState(false, false)] Ray ray,
		[FriendlyName("From", "The starting position of the line. Must be a GameObject or Vector3.")] object objectFrom,
		[FriendlyName("Direction", "The direction of the line. Must be a GameObject or Vector3.")] Vector3 direction
	) {
		Vector3 tempFrom;
			
		if ( objectFrom is GameObject ) {
			GameObject tempGameObject = (GameObject)objectFrom;
			tempFrom = tempGameObject.transform.position;
			
		} else if ( objectFrom is Vector3 ) {
			tempFrom = (Vector3)objectFrom;
				
		} else {
			uScriptDebug.Log("[Draw Ray (Gizmos)] The Draw Ray (Gizmos) node can only take a GameObject or Vector3 for the 'From' input socket.", uScriptDebug.Type.Error);
			tempFrom = Vector3.zero;
				
		}
		
		//Gizmos.DrawRay(ray);
		Gizmos.DrawRay(tempFrom, direction);
		
	}
	
}
