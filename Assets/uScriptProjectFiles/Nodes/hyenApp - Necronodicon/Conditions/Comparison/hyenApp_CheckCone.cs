// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Check if the Target is within a cone.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Check Cone", "Check if the Target is within a cone, defined by the Origin GameObject position within an area of Degrees forward from the Origin. Also returns the Angle from the Origin forward to the Target position. (The Angle range Inside the cone is 1/2 the Degrees) \n\nThis can be useful for checking field of vision, or cone shaped area of effect attacks! \n\nNOTE: Humans have an almost 180-degree field of view, while some birds have a complete or nearly 360-degree field of view.")]
public class hyenApp_CheckCone : uScriptLogic {

	private bool m_Inside = false;

	public bool Inside { get { return m_Inside; } }
	public bool Outside { get { return !m_Inside; } }

	public void In(
		[FriendlyName("Target", "The GameObject or Vector3 position you want to check for in the cone.")] object objectTarget,
		[FriendlyName("Position", "The GameObject or Vector3 that will supply the position for the cone.")] object objectPosition,
		[FriendlyName("Direction", "The forward direction from the GameObject or Vector3 direction that will be used for the cone.")] object objectDirection,
		[FriendlyName("Degree", "The Degree or angle of the cone, from its center or facing direction (1/2 FOV).")] float degree,
		[FriendlyName("Angle", "The angle from Origin forward to the Target position.")] out float angle
	) {
		m_Inside = false;
		
		Vector3 target;
		Vector3 position;
		Vector3 direction;
		
		if ( objectTarget is GameObject ) {
			GameObject tempGameObject = (GameObject)objectTarget;
			target = tempGameObject.transform.position;
		
		} else if ( objectTarget is Vector3 ) {
			target = (Vector3)objectTarget;
			
		} else {
			uScriptDebug.Log("[Check Cone] The Check Cone node can only take a GameObject or Vector3 for the 'Target' input socket.", uScriptDebug.Type.Error);
			target = Vector3.zero;
			
		}
		
		if ( objectPosition is GameObject ) {
			GameObject tempGameObject = (GameObject)objectPosition;
			position = tempGameObject.transform.position;
		
		} else if ( objectPosition is Vector3 ) {
			position = (Vector3)objectPosition;
			
		} else {
			uScriptDebug.Log("[Check Cone] The Check Cone node can only take a GameObject or Vector3 for the 'Position' input socket.", uScriptDebug.Type.Error);
			position = Vector3.zero;
			
		}
		
		if ( objectDirection is GameObject ) {
			GameObject tempGameObject = (GameObject)objectDirection;
			direction = tempGameObject.transform.forward;
		
		} else if ( objectDirection is Vector3 ) {
			direction = (Vector3)objectDirection;
			
		} else {
			uScriptDebug.Log("[Check Cone] The Check Cone node can only take a GameObject or Vector3 for the 'Direction' input socket.", uScriptDebug.Type.Error);
			direction = Vector3.forward;
			
		}
		
		angle = Vector3.Angle(target - position, direction);
		
		if (angle <= degree) {
			m_Inside = true;
		}
		
	}
	
}
