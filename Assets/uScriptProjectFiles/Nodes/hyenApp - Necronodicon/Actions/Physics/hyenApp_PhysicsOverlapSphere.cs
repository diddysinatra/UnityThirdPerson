// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Physics")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns an array with all the GameObjects touching or inside the sphere.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Overlap Sphere", "Returns an array with all the GameObjects touching or inside the sphere. \n\nNOTE: Currently this only checks against the bounding volumes of the colliders not against the actual colliders.")]
public class hyenApp_PhysicsOverlapSphere : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Position", "The center position of the sphere. Must be a GameObject or Vector3.")] object position,
		[FriendlyName("Radius", "The radius of the Sphere.")] float radius,
		[FriendlyName("Use Layer Mask", "If true, the ray will test against the selected layer mask, otherwise it will test against all GameObjects in the scene."), DefaultValue(true), SocketState(false, false)] bool useLayers,
		[FriendlyName("Layer Mask", "A Layer mask that is used to selectively ignore colliders when casting a ray."), SocketState(false, false)] LayerMask layerMask,
		[FriendlyName("GameObjects", "A list with all GameObjects touching or inside the sphere (if any).")] out GameObject[] gameObjectList,
		[FriendlyName("Colliders", "A list with all Colliders touching or inside the sphere (if any)."), SocketState(false, false)] out Collider[] colliderList,
		[FriendlyName("List Size", "The number of items in the Overlapped list.")] out int listSize
	) {
		Vector3 tempPosition;
		
		if ( position is GameObject ) {
			GameObject tempGameObject = (GameObject)position;
			tempPosition = tempGameObject.transform.position;
		
		} else if ( position is Vector3 ) {
			Vector3 tempVector3 = (Vector3)position;
			tempPosition = tempVector3;
			
		} else {
			uScriptDebug.Log("[Overlap Sphere] The Overlap Sphere node can only take a GameObject or Vector3 for the 'Position' input socket.", uScriptDebug.Type.Error);
			tempPosition = Vector3.zero;
			
		}
		
		if ( useLayers ) {
			colliderList = Physics.OverlapSphere(tempPosition, radius, layerMask.value);
			
		} else {
			colliderList = Physics.OverlapSphere(tempPosition, radius);
			
		}
		
		List<GameObject> list = new List<GameObject>();
		
		foreach( Collider collider in colliderList ) {
			list.Add(collider.gameObject);
			
		}
		
		gameObjectList = list.ToArray();
		listSize = gameObjectList.Length;
		
	}
	
}
