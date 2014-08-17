// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Switches")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Manually picks a Touch Count output for use with common multitouch gestures.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Multi Touch Switch", "Manually picks a Touch Count output for use with common multitouch gestures. \n\nThe specified Touch Count value will be clamped within the range of 0 to 255.")]
public class hyenApp_MultiTouchSwitch : uScriptLogic {

	private int m_CurrentOutput = 0;
	//private bool m_SwitchOpen = true;

	public delegate void uScriptEventHandler(object sender, System.EventArgs args);
	[FriendlyName("No Touch")] public event uScriptEventHandler noTouch;
	[FriendlyName("Single Touch")] public event uScriptEventHandler singleTouch;
	[FriendlyName("Double Touch")] public event uScriptEventHandler doubleTouch;
	[FriendlyName("Multi Touch")] public event uScriptEventHandler multiTouch;

	public void In(
		[FriendlyName("Touch Count", "The Touch Count output switch to use.")] int CurrentOutput
	) {
		// Check bounds on MaxOutputUsed
		CurrentOutput = Mathf.Clamp(CurrentOutput, 0, 255);

		m_CurrentOutput = CurrentOutput;

		// Set correct output socket to true
		//if (m_SwitchOpen) {
			switch (m_CurrentOutput) {
				case 0:
					noTouch(this, new System.EventArgs());
					break;

				case 1:
					singleTouch(this, new System.EventArgs());
					break;

				case 2:
					doubleTouch(this, new System.EventArgs());
					break;

				default:
					multiTouch(this, new System.EventArgs());
					break;
			}
			
		//}
		
	}
	
}
