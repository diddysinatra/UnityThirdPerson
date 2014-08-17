// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Physics")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Check if there are any colliders touching the sphere defined by position and radius in world coordinates.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Check Sphere", "Check if there are any colliders touching the sphere defined by position and radius in world coordinates.")]
public class hyenApp_PhysicsCheckSphere : uScriptLogic {

	private bool m_CheckValue = false;

	public bool True { get { return m_CheckValue; } }
	public bool False { get { return !m_CheckValue; } }

	public void In(
		[FriendlyName("Position", "The center position of the sphere. Must be a GameObject or Vector3.")] object position,
		[FriendlyName("Radius", "The radius of the Sphere.")] float radius,
		[FriendlyName("Use Layer Mask", "If true, the ray will test against the selected layer mask, otherwise it will test against all GameObjects in the scene."), DefaultValue(true), SocketState(false, false)] bool useLayers,
		[FriendlyName("Layer Mask", "A Layer mask that is used to selectively ignore colliders when casting a ray."), SocketState(false, false)] LayerMask layerMask
	) {
		Vector3 tempPosition;
		
		if ( position is GameObject ) {
			GameObject tempGameObject = (GameObject)position;
			tempPosition = tempGameObject.transform.position;
			
		} else if ( position is Vector3 ) {
			Vector3 tempVector3 = (Vector3)position;
			tempPosition = tempVector3;
			
		} else {
			uScriptDebug.Log("[Check Sphere] The Check Sphere node can only take a GameObject or Vector3 for the 'Position' input socket.", uScriptDebug.Type.Error);
			tempPosition = Vector3.zero;
			
		}
		
		if ( useLayers ) {
			m_CheckValue = Physics.CheckSphere(tempPosition, radius, layerMask.value);
			
		} else {
			m_CheckValue = Physics.CheckSphere(tempPosition, radius);
			
		}
		
	}
	
}
