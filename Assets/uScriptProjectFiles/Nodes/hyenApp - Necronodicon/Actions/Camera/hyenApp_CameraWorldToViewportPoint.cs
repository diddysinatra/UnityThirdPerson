// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Camera")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Transforms position from world space into viewport space.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("World To Viewport Point", "Transforms position from world space into viewport space. \n\nViewport space is normalized and relative to the camera. The bottom-left of the camera is (0,0); the top-right is (1,1).")]
public class hyenApp_CameraWorldToViewportPoint : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Camera", "The target Camera or GameObject with a camera component attached. Must be a GameObject or Camera.")] object objectCamera,
		[FriendlyName("World", "The World Vector3 or GameObject position. Must be a GameObject or Vector3.")] object worldPosition,
		[FriendlyName("Point", "The normalized viewport Point position (x,y) and distance from the camera (z)."), SocketState(false, false)] out Vector3 viewportPoint,
		[FriendlyName("Position", "The normalized viewport Position.")] out Vector2 viewportPosition,
		[FriendlyName("Distance", "The Distance in world units from the camera.")] out float viewportDistance
	) {
		Camera tempCamera;
		Vector3 tempPosition;
		
		if ( objectCamera is GameObject ) {
			GameObject tempGameObject = (GameObject)objectCamera;
			tempCamera = tempGameObject.camera;
		
		} else if ( objectCamera is Camera ) {
			tempCamera = (Camera)objectCamera;
			
		} else {
			uScriptDebug.Log("[World To Viewport Point] The World To Viewport Point node can only take a GameObject or Camera for the 'Camera' input socket.", uScriptDebug.Type.Error);
			tempCamera = Camera.main;
			
		}
		
		if ( worldPosition is GameObject ) {
			GameObject tempGameObject = (GameObject)worldPosition;
			tempPosition = tempGameObject.transform.position;
		
		} else if ( worldPosition is Vector3 ) {
			Vector3 tempVector3 = (Vector3)worldPosition;
			tempPosition = tempVector3;
			
		} else {
			uScriptDebug.Log("[World To Viewport Point] The World To Viewport Point node can only take a GameObject or Vector3 for the 'World' input socket.", uScriptDebug.Type.Error);
			tempPosition = Vector3.zero;
			
		}
		
		viewportPoint = tempCamera.WorldToViewportPoint(tempPosition);
		viewportPosition = new Vector2(viewportPoint.x, viewportPoint.y);
		viewportDistance = viewportPoint.z;
		
	}
	
}
