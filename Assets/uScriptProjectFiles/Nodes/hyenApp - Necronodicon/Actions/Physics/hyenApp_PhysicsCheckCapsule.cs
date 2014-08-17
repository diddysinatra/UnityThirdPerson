// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Physics")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Check if there are any colliders touching the capsule defined by the axis going from start and end and having radius in world coordinates.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Check Capsule", "Check if there are any colliders touching the capsule defined by the axis going from start and end and having radius in world coordinates.")]
public class hyenApp_PhysicsCheckCapsule : uScriptLogic {

	private bool m_CheckValue = false;

	public bool True { get { return m_CheckValue; } }
	public bool False { get { return !m_CheckValue; } }

	public void In(
		[FriendlyName("Start", "The start position of the sphere. Must be a GameObject or Vector3.")] object start,
		[FriendlyName("End", "The end position of the sphere. Must be a GameObject or Vector3.")] object end,
		[FriendlyName("Radius", "The radius of the Sphere.")] float radius,
		[FriendlyName("Use Layer Mask", "If true, the ray will test against the selected layer mask, otherwise it will test against all GameObjects in the scene."), DefaultValue(true), SocketState(false, false)] bool useLayers,
		[FriendlyName("Layer Mask", "A Layer mask that is used to selectively ignore colliders when casting a ray."), SocketState(false, false)] LayerMask layerMask
	) {
		Vector3 tempStart;
		
		if ( start is GameObject ) {
			GameObject tempGameObject = (GameObject)start;
			tempStart = tempGameObject.transform.position;
			
		} else if ( start is Vector3 ) {
			Vector3 tempVector3 = (Vector3)start;
			tempStart = tempVector3;
			
		} else {
			uScriptDebug.Log("[Check Capsule] The Overlap Sphere node can only take a GameObject or Vector3 for the 'Start' input socket.", uScriptDebug.Type.Error);
			tempStart = Vector3.zero;
			
		}
		
		Vector3 tempEnd;
		
		if ( end is GameObject ) {
			GameObject tempGameObject = (GameObject)end;
			tempEnd = tempGameObject.transform.position;
			
		} else if ( end is Vector3 ) {
			Vector3 tempVector3 = (Vector3)end;
			tempEnd = tempVector3;
			
		} else {
			uScriptDebug.Log("[Check Capsule] The Check Capsule node can only take a GameObject or Vector3 for the 'End' input socket.", uScriptDebug.Type.Error);
			tempEnd = Vector3.zero;
			
		}
		
		if ( useLayers ) {
			m_CheckValue = Physics.CheckCapsule(tempStart, tempEnd, radius, layerMask.value);
			
		} else {
			m_CheckValue = Physics.CheckCapsule(tempStart, tempEnd, radius);
			
		}
		
	}
	
}
