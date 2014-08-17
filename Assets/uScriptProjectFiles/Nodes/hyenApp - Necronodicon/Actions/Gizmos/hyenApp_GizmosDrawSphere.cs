// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Gizmos")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Draws a wireframe or solid sphere with center position and radius.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Draw Sphere (Gizmos)", "Draws a wireframe or solid sphere with center position and radius.")]
public class hyenApp_GizmosDrawSphere : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Position", "The center position of the sphere. Must be a GameObject or Vector3.")] object position,
		[FriendlyName("Radius", "The radius of the Sphere. Must be a GameObject or float. If the GameObject's Collider or Renderer is null this node will create a new bounds that encapsulate its children's Colliders or Renderers.")] object radius,
		[FriendlyName("Use Collider", "True if you want to use the GameObject's max Collider extents to draw the sphere, and False if you want to use the GameObject's max Renderer extents to draw the sphere."), DefaultValue(true), SocketState(false, false)] bool useCollider,
		[FriendlyName("Wireframe", "If true draw a Wire Sphere, if false draw a Solid Sphere."), DefaultValue(true), SocketState(false, false)] bool wireframe
	) {
		Vector3 tempPosition;
		
		if ( position is GameObject ) {
			GameObject tempGameObject = (GameObject)position;
			tempPosition = tempGameObject.transform.position;
		
		} else if ( position is Vector3 ) {
			Vector3 tempVector3 = (Vector3)position;
			tempPosition = tempVector3;
			
		} else {
			uScriptDebug.Log("[Draw Sphere (Gizmos)] The Draw Sphere (Gizmos) node can only take a GameObject or Vector3 for the 'Position' input socket.", uScriptDebug.Type.Error);
			tempPosition = Vector3.zero;
			
		}
		
		float tempRadius;
		
		if ( radius is GameObject ) {
			GameObject tempGameObject = (GameObject)radius;
			Bounds tempBounds;
			
			if ( useCollider ) {
				
				if (null != tempGameObject.collider) {
					tempBounds = tempGameObject.collider.bounds;
				} else {
					tempBounds = new Bounds(tempGameObject.transform.position, Vector3.zero);
					Component[] colliders = tempGameObject.GetComponentsInChildren<Collider>();
					
					foreach (Collider collider in colliders) {
						tempBounds.Encapsulate(collider.collider.bounds);
					}
			
				}
				
			} else {
				
				if (null != tempGameObject.renderer) {
					tempBounds = tempGameObject.renderer.bounds;
				} else {
					tempBounds = new Bounds(tempGameObject.transform.position, Vector3.zero);
					Component[] meshes = tempGameObject.GetComponentsInChildren<MeshFilter>();
					
					foreach (MeshFilter mesh in meshes) {
						tempBounds.Encapsulate(mesh.renderer.bounds);
					}
			
				}
				
			}
			
			tempRadius = tempBounds.extents.x;
			tempRadius = Mathf.Max(tempRadius, tempBounds.extents.y);
			tempRadius = Mathf.Max(tempRadius, tempBounds.extents.z);
			
			if ( position == radius ) {
				tempPosition = tempBounds.center;
			}
		
		} else if ( radius is float ) {
			float tempFloat = (float)radius;
			tempRadius = tempFloat;
			
		} else {
			uScriptDebug.Log("[Draw Sphere (Gizmos)] The Draw Sphere (Gizmos) node can only take a GameObject or float for the 'Radius' input socket.", uScriptDebug.Type.Error);
			tempRadius = 1.0f;
			
		}
		
		if ( wireframe ) {
			Gizmos.DrawWireSphere(tempPosition, tempRadius);
			
		} else {
			Gizmos.DrawSphere(tempPosition, tempRadius);
			
		}
		
	}
	
}
