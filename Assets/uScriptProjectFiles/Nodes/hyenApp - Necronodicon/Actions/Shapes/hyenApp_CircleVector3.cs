// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Shapes")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Calculates a List of Vector3 points that describe a circle or sliced circle.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Circle (Vector3)", "Calculates a List of Vector3 points that describe a circle or sliced circle.")]
public class hyenApp_CircleVector3 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Position", "The center position of the circle. Must be a GameObject or Vector3.")] object objectPosition,
		[FriendlyName("Radius", "The radius of the circle. Must be a GameObject or float. If the GameObject's Collider or Renderer is null this node will create a new bounds that encapsulate its children's Colliders or Renderers.")] object objectRadius,
		[FriendlyName("Use Collider", "True if you want to use the GameObject's max Collider extents to draw the circle, and False if you want to use the GameObject's max Renderer extents to draw the circle."), DefaultValue(true), SocketState(false, false)] bool useCollider,
		[FriendlyName("Sides", "The number of sides to draw the circle with. Must be 3 or more."), DefaultValue(16F), SocketState(false, false)] int sides,
		[FriendlyName("Slice", ""), DefaultValue(false), SocketState(false, false)] bool slice,
		[FriendlyName("Slice From", ""), DefaultValue(0F), SocketState(false, false)] float sliceFrom,
		[FriendlyName("Slice To", ""), DefaultValue(0F), SocketState(false, false)] float sliceTo,
		[FriendlyName("Circle", "")] out Vector3[] circle
	) {
		if (sides < 3) sides = 3;
		
		float offset;
		float angle;
		
		if (slice) {
			offset = (sliceTo - sliceFrom) / sides;
			angle = sliceFrom;
		} else {
			offset = 360F / sides;
			angle = 0F;
		}
		
		Vector3 position;
		float radius;
		
		if ( objectPosition is GameObject ) {
			GameObject tempGameObject = (GameObject)objectPosition;
			position = tempGameObject.transform.position;
		
		} else if ( objectPosition is Vector3 ) {
			position = (Vector3)objectPosition;
			
		} else {
			uScriptDebug.Log("[Draw Circle (Gizmos)] The Draw Circle (Gizmos) node can only take a GameObject or Vector3 for the 'Position' input socket.", uScriptDebug.Type.Error);
			position = Vector3.zero;
			
		}
		
		if ( objectRadius is GameObject ) {
			GameObject tempGameObject = (GameObject)objectRadius;
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
			
			radius = tempBounds.extents.x;
			radius = Mathf.Max(radius, tempBounds.extents.y);
			radius = Mathf.Max(radius, tempBounds.extents.z);
			
			if ( objectPosition == objectRadius ) {
				position = tempBounds.center;
			}
		
		} else if ( objectRadius is float ) {
			radius = (float)objectRadius;
			
		} else {
			uScriptDebug.Log("[Draw Circle (Gizmos)] The Draw Circle (Gizmos) node can only take a GameObject or float for the 'Radius' input socket.", uScriptDebug.Type.Error);
			radius = 1.0f;
			
		}
		
		circle = new Vector3[sides + 1];
		
		for(var i = 0; i < circle.Length; i++) {
			circle[i] = new Vector3(position.x + radius * Mathf.Cos((angle - 90) * Mathf.Deg2Rad), position.y, position.z - radius * Mathf.Sin((angle - 90) * Mathf.Deg2Rad));
			angle += offset;
			
		}
		
	}
	
}
