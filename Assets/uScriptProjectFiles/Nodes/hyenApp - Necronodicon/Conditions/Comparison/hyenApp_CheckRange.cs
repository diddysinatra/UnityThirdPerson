// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Check the range between GameObject or Vector3 positions.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Check Range", "Check the range between GameObject or Vector3 positions. Also returns the distance between A and B.")]
public class hyenApp_CheckRange : uScriptLogic {

	private bool m_Closer = false;
	private bool m_InRange = false;
	private bool m_Further = false;

	[FriendlyName("Closer")] public bool Closer { get { return m_Closer; } }
	[FriendlyName("In Range")] public bool InRange { get { return m_InRange; } }
	[FriendlyName("Further")] public bool Further { get { return m_Further; } }

	public void In(
		[FriendlyName("A", "First position must be a GameObject or Vector3.")] object objectA,
		[FriendlyName("B", "Second position must be a GameObject or Vector3.")] object objectB,
		[FriendlyName("Min", "The Minimum distance within range.")] float min,
		[FriendlyName("Max", "The Maximum distance within range.")] float max,
		[FriendlyName("Distance", "The distance between A and B.")] out float distance
	) {
		m_Closer = false;
		m_InRange = false;
		m_Further = false;
		
		Vector3 tempA;
		Vector3 tempB;
		
		if ( objectA is GameObject ) {
			GameObject tempGameObject = (GameObject)objectA;
			tempA = tempGameObject.transform.position;
		
		} else if ( objectA is Vector3 ) {
			tempA = (Vector3)objectA;
			
		} else {
			uScriptDebug.Log("[Check Range] The Check Range node can only take a GameObject or Vector3 for the 'A' input socket.", uScriptDebug.Type.Error);
			tempA = Vector3.zero;
			
		}
		
		if ( objectB is GameObject ) {
			GameObject tempGameObject = (GameObject)objectB;
			tempB = tempGameObject.transform.position;
		
		} else if ( objectB is Vector3 ) {
			tempB = (Vector3)objectB;
			
		} else {
			uScriptDebug.Log("[Check Range] The Check Range node can only take a GameObject or Vector3 for the 'B' input socket.", uScriptDebug.Type.Error);
			tempB = Vector3.zero;
			
		}
		
		distance = Vector3.Distance(tempA, tempB);
		
		if (distance > max) {
			m_Further = true;
		} else if (distance < min) {
			m_Closer = true;
		} else {
			m_InRange = true;
		}
		
	}
	
}
