// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Camera")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Transforms position from world space into screen space.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("World To Screen Point", "Transforms position from world space into screen space. \n\nScreenspace is defined in pixels. The bottom-left of the screen is (0,0); the right-top is (screenWidth,screenHeight).")]
public class hyenApp_CameraWorldToScreenPoint : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Camera", "The target Camera or GameObject with a camera component attached. Must be a GameObject or Camera.")] object objectCamera,
		[FriendlyName("World", "The World Vector3 or GameObject position. Must be a GameObject or Vector3.")] object worldPosition,
		[FriendlyName("Point", "The screen Point position (x,y) and distance from the camera (z)."), SocketState(false, false)] out Vector3 screenPoint,
		[FriendlyName("Position", "The screen Position in pixels.")] out Vector2 screenPosition,
		[FriendlyName("Distance", "The Distance in world units from the camera.")] out float screenDistance
	) {
		Camera tempCamera;
		Vector3 tempPosition;
		
		if ( objectCamera is GameObject ) {
			GameObject tempGameObject = (GameObject)objectCamera;
			tempCamera = tempGameObject.camera;
		
		} else if ( objectCamera is Camera ) {
			tempCamera = (Camera)objectCamera;
			
		} else {
			uScriptDebug.Log("[World To Screen Point] The World To Screen Point node can only take a GameObject or Camera for the 'Camera' input socket.", uScriptDebug.Type.Error);
			tempCamera = Camera.main;
			
		}
		
		if ( worldPosition is GameObject ) {
			GameObject tempGameObject = (GameObject)worldPosition;
			tempPosition = tempGameObject.transform.position;
		
		} else if ( worldPosition is Vector3 ) {
			Vector3 tempVector3 = (Vector3)worldPosition;
			tempPosition = tempVector3;
			
		} else {
			uScriptDebug.Log("[World To Screen Point] The World To Screen Point node can only take a GameObject or Vector3 for the 'World' input socket.", uScriptDebug.Type.Error);
			tempPosition = Vector3.zero;
			
		}
		
		screenPoint = tempCamera.WorldToScreenPoint(tempPosition);
		screenPosition = new Vector2(screenPoint.x, screenPoint.y);
		screenDistance = screenPoint.z;
		
	}
	
}
