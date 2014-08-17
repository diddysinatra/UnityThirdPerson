// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Gizmos")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Draws a line starting at From towards To.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Draw Line (Gizmos)", "Draws a line starting at From towards To.")]
public class hyenApp_GizmosDrawLine : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("From", "The starting position of the line. Must be a GameObject or Vector3.")] object objectFrom,
		[FriendlyName("To", "The ending position of the line. Must be a GameObject or Vector3.")] object objectTo
	) {
		Vector3 tempFrom;
		
		if ( objectFrom is GameObject ) {
			GameObject tempGameObject = (GameObject)objectFrom;
			tempFrom = tempGameObject.transform.position;
		
		} else if ( objectFrom is Vector3 ) {
			Vector3 tempVector3 = (Vector3)objectFrom;
			tempFrom = tempVector3;
			
		} else {
			uScriptDebug.Log("[Draw Line (Gizmos)] The Draw Line (Gizmos) node can only take a GameObject or Vector3 for the 'From' input socket.", uScriptDebug.Type.Error);
			tempFrom = Vector3.zero;
			
		}
		
		Vector3 tempTo;
		
		if ( objectTo is GameObject ) {
			GameObject tempGameObject = (GameObject)objectTo;
			tempTo = tempGameObject.transform.position;
		
		} else if ( objectTo is Vector3 ) {
			Vector3 tempVector3 = (Vector3)objectTo;
			tempTo = tempVector3;
			
		} else {
			uScriptDebug.Log("[Draw Line (Gizmos)] The Draw Line (Gizmos) node can only take a GameObject or Vector3 for the 'To' input socket.", uScriptDebug.Type.Error);
			tempTo = Vector3.zero;
			
		}
		
		Gizmos.DrawLine(tempFrom, tempTo);
		
	}
	
}
