// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Gyroscope")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Touch variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (Gyroscope)", "Gets the components of a Gyroscope variable. \n\nUse this node to access Gyroscope data.")]
public class hyenApp_GetComponentsGyroscope : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Gyroscope", "The target Gyroscope variable.")] Gyroscope gyroscope,
		[FriendlyName("Rotation Rate", "Returns rotation rate as measured by the device's gyroscope.")] out Vector3 rotationRate,
		[FriendlyName("Rotation Rate Unbiased", "Returns unbiased rotation rate as measured by the device's gyroscope.")] out Vector3 rotationRateUnbiased,
		[FriendlyName("Gravity", "Returns the gravity acceleration vector expressed in the device's reference frame.")] out Vector3 gravity,
		[FriendlyName("User Acceleration", "Returns the acceleration that the user is giving to the device.")] out Vector3 userAcceleration,
		[FriendlyName("Attitude", "Returns the attitude of the device.")] out Quaternion attitude,
		[FriendlyName("Enabled", "Gets the status of this gyroscope.")] out bool enabled,
		[FriendlyName("Update Interval", "Gets the gyroscope interval in seconds.")] out float updateInterval
	) {
		rotationRate = gyroscope.rotationRate;
		rotationRateUnbiased = gyroscope.rotationRateUnbiased;
		gravity = gyroscope.gravity;
		userAcceleration = gyroscope.userAcceleration;
		attitude = gyroscope.attitude;
		enabled = gyroscope.enabled;
		updateInterval =gyroscope.updateInterval;
		
	}
	
}
