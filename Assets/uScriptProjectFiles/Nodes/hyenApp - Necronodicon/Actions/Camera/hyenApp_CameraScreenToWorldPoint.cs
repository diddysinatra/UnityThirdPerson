// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Camera")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Transforms position from screen space into world space.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Screen To World Point", "Transforms position from screen space into world space. \n\nScreenspace is defined in pixels. The bottom-left of the screen is (0,0); the right-top is (pixelWidth,pixelHeight). The z position is in world units from the camera.")]
public class hyenApp_CameraScreenToWorldPoint : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Camera", "The target Camera or GameObject with a camera component attached. Must be a GameObject or Camera.")] object objectCamera,
		[FriendlyName("Position", "The screen Position to Transform. Must be a Vector3 or Vector2. (If a Vector2 value is used don't forget to connect the distance socket.)")] object objectPosition,
		[FriendlyName("Distance", "The Distance value is used only when a Vector2 value is connected to the Position socket."), DefaultValue(0F), SocketState(false, false)] float distance,
		[FriendlyName("World", "The World point Vector3.")] out Vector3 worldPoint
	) {
		Camera tempCamera;
		Vector3 tempPosition;
		
		if ( objectCamera is GameObject ) {
			GameObject tempGameObject = (GameObject)objectCamera;
			tempCamera = tempGameObject.camera;
		
		} else if ( objectCamera is Camera ) {
			tempCamera = (Camera)objectCamera;
			
		} else {
			uScriptDebug.Log("[Viewport To World Point] The Viewport To World Point node can only take a GameObject or Camera for the 'Camera' input socket.", uScriptDebug.Type.Error);
			tempCamera = Camera.main;
			
		}
		
		if ( objectPosition is Vector3 ) {
			tempPosition = (Vector3)objectPosition;
			
		} else if ( objectPosition is Vector2 ) {
			Vector2 tempVector2 = (Vector2)objectPosition;
			tempPosition = new Vector3(tempVector2.x, tempVector2.y, distance);
			
		} else {
			uScriptDebug.Log("[Viewport To World Point] The Viewport To World Pointt node can only take a Vector3 or Vector2 for the 'Position' input socket.", uScriptDebug.Type.Error);
			//tempPosition = new Vector3(0.5f, 0.5f, tempCamera.nearClipPlane);
			tempPosition = Vector3.zero;
			
		}
		
		worldPoint = tempCamera.ScreenToWorldPoint(tempPosition);
		
	}
	
}
