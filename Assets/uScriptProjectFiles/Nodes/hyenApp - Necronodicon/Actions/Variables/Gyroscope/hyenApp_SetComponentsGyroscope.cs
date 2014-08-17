// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Gyroscope")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets the components of a Touch variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Components (Gyroscope)", "Sets the components of a Gyroscope variable.")]
public class hyenApp_SetComponentsGyroscope : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Gyroscope", "The target Gyroscope variable.")] Gyroscope gyroscope,
		[FriendlyName("Enabled", "Sets the status of this gyroscope.")] bool enabled,
		[FriendlyName("Update Interval", "Sets the gyroscope interval in seconds.")] float updateInterval
	) {
		gyroscope.enabled = enabled;
		gyroscope.updateInterval = updateInterval;
		
	}
	
}
