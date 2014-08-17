// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Switches")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Manually pick a TouchPhase output to fire the signal to.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("TouchPhase Switch", "Manually pick a TouchPhase output to fire the signal to.\n\nIf no Output is specified the TouchPhase.Canceled value will be used.")]
public class hyenApp_TouchPhaseSwitch : uScriptLogic {

	private TouchPhase m_CurrentOutput = TouchPhase.Canceled;
	private bool m_SwitchOpen = true;

	public delegate void uScriptEventHandler(object sender, System.EventArgs args);
	[FriendlyName("Began", "A finger touched the screen.")] public event uScriptEventHandler Began;
	[FriendlyName("Moved", "A finger moved on the screen.")] public event uScriptEventHandler Moved;
	[FriendlyName("Stationary", "A finger is touching the screen but hasn't moved.")] public event uScriptEventHandler Stationary;
	[FriendlyName("Ended", "A finger was lifted from the screen. This is the final phase of a touch.")] public event uScriptEventHandler Ended;
	[FriendlyName("Canceled", "The system cancelled tracking for the touch, as when (for example) the user puts the device to her face or more than five touches happened simultaneously. This is the final phase of a touch.")] public event uScriptEventHandler Canceled;
	
	public void In(
		[FriendlyName("Output To Use", "The output switch to use.")] TouchPhase CurrentOutput
	) {
		m_CurrentOutput = CurrentOutput;
		
		// Set correct output socket to true
		if (m_SwitchOpen) {
			switch (m_CurrentOutput) {
				case TouchPhase.Began:
					Began(this, new System.EventArgs());
					break;
				
				case TouchPhase.Moved:
					Moved(this, new System.EventArgs());
					break;
				
				case TouchPhase.Stationary:
					Stationary(this, new System.EventArgs());
					break;

				case TouchPhase.Ended:
					Ended(this, new System.EventArgs());
					break;

				case TouchPhase.Canceled:
					Canceled(this, new System.EventArgs());
					break;

			}
			
		}
		
	}
	
}
