// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns an array of strings describing the connected joysticks.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Get Joystick Names", "Returns an array of strings describing the connected joysticks. \n\nThis can be useful in user input configuration screens - this way, instead of showing labels like 'Joystick 1', you can show more meaningful names like 'Logitech WingMan'. To read values from different joysticks, you need to assign respective axes for the number of joysticks you want to support in the input manager.")]
public class hyenApp_InputGetJoystickNames : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Joystick Names", "")] out string[] names
	) {
		names = Input.GetJoystickNames( );
		
	}
	
}
