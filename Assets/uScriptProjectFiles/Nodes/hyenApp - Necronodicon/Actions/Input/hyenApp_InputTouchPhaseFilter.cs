// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Filters the output based on the Phase of the Touch.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Touch Phase Filter", "Filters the output based on the Phase of the Touch.")]
public class hyenApp_InputTouchPhaseFilter : uScriptLogic {

	//private bool m_SwitchOpen = true;

	public delegate void uScriptEventHandler(object sender, System.EventArgs args);
	[FriendlyName("Began", "The finger touched the screen.")] public event uScriptEventHandler Began;
	[FriendlyName("Moved", "The finger moved on the screen.")] public event uScriptEventHandler Moved;
	[FriendlyName("Stationary", "The finger is touching the screen but hasn't moved.")] public event uScriptEventHandler Stationary;
	[FriendlyName("Ended", "The finger was lifted from the screen. This is the final phase of a touch.")] public event uScriptEventHandler Ended;
	[FriendlyName("Canceled", "The system cancelled tracking for the touch, as when (for example) the user puts the device to her face or more than five touches happened simultaneously. This is the final phase of a touch.")] public event uScriptEventHandler Canceled;
	
	public void In(
		[FriendlyName("Index", "If an Index grater then -1 is specified it will be used to get the Touch for the Phase filter."), DefaultValue(-1), SocketState(false, false)] int index,
		[FriendlyName("Touch", "The Touch used for the Phase filter.")] Touch touch
	) {
		if (index > -1) {
			touch = Input.GetTouch(index);
		}
		
		// Set correct output socket to true
		//if (m_SwitchOpen) {
			switch (touch.phase) {
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
			
		//}
		
	}
	
}
