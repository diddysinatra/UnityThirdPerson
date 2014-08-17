// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Switches")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Manually pick an Output between 1 and 9 to fire the signal to.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Manual Switch 9", "Manually pick an Output between 1 and 9 to fire the signal to. \n\nThe specified Output To Use value will be clamped within the range of 1 to 9.")]
public class hyenApp_ManualSwitch9 : uScriptLogic {

	private int m_CurrentOutput = 1;
	private bool m_SwitchOpen = true;

	public delegate void uScriptEventHandler(object sender, System.EventArgs args);
	[FriendlyName("Output 1")] public event uScriptEventHandler Output1;
	[FriendlyName("Output 2")] public event uScriptEventHandler Output2;
	[FriendlyName("Output 3")] public event uScriptEventHandler Output3;
	[FriendlyName("Output 4")] public event uScriptEventHandler Output4;
	[FriendlyName("Output 5")] public event uScriptEventHandler Output5;
	[FriendlyName("Output 6")] public event uScriptEventHandler Output6;
	[FriendlyName("Output 7")] public event uScriptEventHandler Output7;
	[FriendlyName("Output 8")] public event uScriptEventHandler Output8;
	[FriendlyName("Output 9")] public event uScriptEventHandler Output9;

	public void In(
		[FriendlyName("Output To Use", "The output switch to use.")] int CurrentOutput
	) {
		// Check bounds on MaxOutputUsed
		CurrentOutput = Mathf.Clamp(CurrentOutput, 1, 9);

		m_CurrentOutput = CurrentOutput;

		// Set correct output socket to true
		if (m_SwitchOpen) {
			switch (m_CurrentOutput) {
				case 1:
					Output1(this, new System.EventArgs());
					break;

				case 2:
					Output2(this, new System.EventArgs());
					break;

				case 3:
					Output3(this, new System.EventArgs());
					break;

				case 4:
					Output4(this, new System.EventArgs());
					break;

				case 5:
					Output5(this, new System.EventArgs());
					break;

				case 6:
					Output6(this, new System.EventArgs());
					break;
				
				case 7:
					Output7(this, new System.EventArgs());
					break;
				
				case 8:
					Output8(this, new System.EventArgs());
					break;
				
				case 9:
					Output9(this, new System.EventArgs());
					break;

				default:
					break;
			}
			
		}
		
	}

}
