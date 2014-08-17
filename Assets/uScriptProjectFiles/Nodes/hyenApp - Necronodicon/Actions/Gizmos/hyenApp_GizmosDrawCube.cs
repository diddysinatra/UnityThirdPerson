// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Gizmos")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Draws a wireframe or solid cube with center position and size.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Draw Cube (Gizmos)", "Draws a wireframe or solid cube with center position and size.")]
public class hyenApp_GizmosDrawCube : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Position", "The center position of the cube. Must be a GameObject or Vector3.")] object position,
		[FriendlyName("Size", "The size of the cube. Must be a GameObject or Vector3. If the Size GameObject's Collider or Renderer is null this node will create a new bounds that encapsulate its children's Colliders or Renderers.")] object size,
		[FriendlyName("Use Collider", "True if you want to use the GameObject's Collider size to draw the cube, and False if you want to use the GameObject's Renderer size to draw the cube."), DefaultValue(true), SocketState(false, false)] bool useCollider,
		[FriendlyName("Wireframe", "If true draw a Wire Cube, if false draw a Solid Cube."), DefaultValue(true), SocketState(false, false)] bool wireframe
	) {
		Vector3 tempPosition;
		
		if ( position is GameObject ) {
			GameObject tempGameObject = (GameObject)position;
			tempPosition = tempGameObject.transform.position;
		
		} else if ( position is Vector3 ) {
			Vector3 tempVector3 = (Vector3)position;
			tempPosition = tempVector3;
			
		} else {
			uScriptDebug.Log("[Draw Cube (Gizmos)] The Draw Cube (Gizmos) node can only take a GameObject or Vector3 for the 'Position' input socket.", uScriptDebug.Type.Error);
			tempPosition = Vector3.zero;
			
		}
		
		Vector3 tempSize;
		
		if ( size is GameObject ) {
			GameObject tempGameObject = (GameObject)size;
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

			tempSize = tempBounds.size;
			
			if ( position == size ) {
				tempPosition = tempBounds.center;
			}
		
		} else if ( size is Vector3 ) {
			Vector3 tempVector3 = (Vector3)size;
			tempSize = tempVector3;
			
		} else {
			uScriptDebug.Log("[Draw Cube (Gizmos)] The Draw Cube (Gizmos) node can only take a GameObject or Vector3 for the 'Size' input socket.", uScriptDebug.Type.Error);
			tempSize = Vector3.one;
			
		}
		
		if ( wireframe ) {
			Gizmos.DrawWireCube(tempPosition, tempSize);
			
		} else {
			Gizmos.DrawCube(tempPosition, tempSize);
			
		}
		
	}
	
}
