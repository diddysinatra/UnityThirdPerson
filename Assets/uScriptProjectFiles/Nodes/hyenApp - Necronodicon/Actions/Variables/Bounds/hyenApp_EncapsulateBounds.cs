// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Bounds")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Grows the Bounds to include the Target.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Encapsulate Bounds", "Grows the Bounds to include the Target.")]
public class hyenApp_EncapsulateBounds : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Bounds", "The Bounds variable you wish to grow to include the Target.")] Bounds bounds,
		[FriendlyName("Targets", "Grow the Bounds variable to include this Vector3 or Vector3 List, GameObject or GameObject List, and Bounds or Bounds List. (If the GameObjects collider or renderer is null this node will create a new bounds that encapsulates its children's colliders or renderers.)")] object targets,
		[FriendlyName("Use Collider", "True if you want to encapsulate the GameObject's Collider, and False if you want to encapsulate the GameObject's Renderer."), DefaultValue(true), SocketState(false, false)] bool useCollider,
		[FriendlyName("Result", "The Resulting Bounds value.")] out Bounds result
	) {
		result = bounds;
		
		if ( targets is GameObject[] ) {
			GameObject[] gameObjectList = (GameObject[])targets;
			foreach (GameObject gameObject in gameObjectList) {
				Bounds tempBounds;
				if (useCollider) {
					if (null != gameObject.collider) {
						tempBounds = gameObject.collider.bounds;
						
					} else {
						tempBounds = new Bounds(gameObject.transform.position, Vector3.zero);
						Component[] colliders = gameObject.GetComponentsInChildren<Collider>();
						foreach (Collider collider in colliders) {
							tempBounds.Encapsulate(collider.collider.bounds);
							
						}
						
					}
					
				} else {
					if (null != gameObject.renderer) {
						tempBounds = gameObject.renderer.bounds;
						
					} else {
						tempBounds = new Bounds(gameObject.transform.position, Vector3.zero);
						Component[] meshes = gameObject.GetComponentsInChildren<MeshFilter>();
						foreach (MeshFilter mesh in meshes) {
							tempBounds.Encapsulate(mesh.renderer.bounds);
							
						}
			
					}
					
				}
				
				result.Encapsulate(tempBounds);
				
			}
		
		} else if ( targets is GameObject ) {
			GameObject gameObject = (GameObject)targets;
			Bounds tempBounds;
			if (useCollider) {
				if (null != gameObject.collider) {
					tempBounds = gameObject.collider.bounds;
					
				} else {
					tempBounds = new Bounds(gameObject.transform.position, Vector3.zero);
					Component[] colliders = gameObject.GetComponentsInChildren<Collider>();
					foreach (Collider collider in colliders) {
						tempBounds.Encapsulate(collider.collider.bounds);
							
					}
					
				}
				
			} else {
				if (null != gameObject.renderer) {
					tempBounds = gameObject.renderer.bounds;
					
				} else {
					tempBounds = new Bounds(gameObject.transform.position, Vector3.zero);
					Component[] meshes = gameObject.GetComponentsInChildren<MeshFilter>();
					foreach (MeshFilter mesh in meshes) {
						tempBounds.Encapsulate(mesh.renderer.bounds);
						
					}
					
				}
					
			}
				
			result.Encapsulate(tempBounds);
			
		} else if ( targets is Vector3[] ) {
			Vector3[] vector3List = (Vector3[])targets;
			foreach (Vector3 vector3 in vector3List) {
				result.Encapsulate(vector3);
				
			}
			
		} else if ( targets is Vector3 ) {
			Vector3 vector3 = (Vector3)targets;
			result.Encapsulate(vector3);
			
		} else if ( targets is Bounds[] ) {
			Bounds[] boundsList = (Bounds[])targets;
			foreach (Bounds bound in boundsList) {
				result.Encapsulate(bound);
				
			}
			
		} else if ( targets is Bounds ) {
			Bounds bound = (Bounds)targets;
			result.Encapsulate(bound);
			
		} else {
			uScriptDebug.Log("[Encapsulate Bounds] The Encapsulate Bounds node can only take a GameObject[], Vector3[], or Bounds[] for the 'Targets' input socket.", uScriptDebug.Type.Error);
			
		}
		
	}
	
}
