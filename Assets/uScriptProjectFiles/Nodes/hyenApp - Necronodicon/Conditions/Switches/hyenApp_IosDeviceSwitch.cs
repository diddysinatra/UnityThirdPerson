// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Switches")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Manually pick an iOS Device output to fire the signal to.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("iOS Device Switch", "Manually pick an iOS Device output to fire the signal to.\n\nIf no Output is specified the iPhone.generation value will be used.")]
public class hyenApp_IosDeviceSwitch : uScriptLogic {

	private bool m_SwitchOpen = true;

	public delegate void uScriptEventHandler(object sender, System.EventArgs args);
	[FriendlyName("iPhone", "First generation device")] public event uScriptEventHandler iPhone;
	[FriendlyName("iPhone3G", "Second generation")] public event uScriptEventHandler iPhone3G;
	[FriendlyName("iPhone3GS", "Third generation")] public event uScriptEventHandler iPhone3GS;
	[FriendlyName("iPhone4", "Fourth generation")] public event uScriptEventHandler iPhone4;
	[FriendlyName("iPhone4S", "Fifth generation")] public event uScriptEventHandler iPhone4S;
	[FriendlyName("iPhone5", "iPhone5")] public event uScriptEventHandler iPhone5;
	[FriendlyName("iPhoneUnknown", "Yet unknown iPhone")] public event uScriptEventHandler iPhoneUnknown;
	[FriendlyName("iPodTouch1Gen", "iPod Touch, first generation")] public event uScriptEventHandler iPodTouch1Gen;
	[FriendlyName("iPodTouch2Gen", "iPod Touch, second generation")] public event uScriptEventHandler iPodTouch2Gen;
	[FriendlyName("iPodTouch3Gen", "iPod Touch, third generation")] public event uScriptEventHandler iPodTouch3Gen;
	[FriendlyName("iPodTouch4Gen", "iPod Touch, fourth generation")] public event uScriptEventHandler iPodTouch4Gen;
	[FriendlyName("iPodTouch5Gen", "iPod Touch, fifth generation")] public event uScriptEventHandler iPodTouch5Gen;
	[FriendlyName("iPodTouchUnknown", "Yet unknown iPodTouch")] public event uScriptEventHandler iPodTouchUnknown;
	[FriendlyName("iPad1Gen", "iPad, first generation")] public event uScriptEventHandler iPad1Gen;
	[FriendlyName("iPad2Gen", "iPad, second generation")] public event uScriptEventHandler iPad2Gen;
	[FriendlyName("iPad3Gen", "iPad, third generation")] public event uScriptEventHandler iPad3Gen;
	[FriendlyName("iPadUnknown", "Yet unknown iPad")] public event uScriptEventHandler iPadUnknown;
	[FriendlyName("Unknown", "")] public event uScriptEventHandler Unknown;

	public void In(
		[FriendlyName("Output To Use", "The output switch to use.")] [DefaultValue(iPhoneGeneration.Unknown)] iPhoneGeneration CurrentOutput
	) {
		// Set correct output socket to true
		if (m_SwitchOpen) {
			switch (CurrentOutput) {
				case iPhoneGeneration.iPhone:
					iPhone(this, new System.EventArgs());
					break;

				case iPhoneGeneration.iPhone3G:
					iPhone3G(this, new System.EventArgs());
					break;

				case iPhoneGeneration.iPhone3GS:
					iPhone3GS(this, new System.EventArgs());
					break;

				case iPhoneGeneration.iPodTouch1Gen:
					iPodTouch1Gen(this, new System.EventArgs());
					break;

				case iPhoneGeneration.iPodTouch2Gen:
					iPodTouch2Gen(this, new System.EventArgs());
					break;

				case iPhoneGeneration.iPodTouch3Gen:
					iPodTouch3Gen(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPad1Gen:
					iPad1Gen(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPhone4:
					iPhone4(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPodTouch4Gen:
					iPodTouch4Gen(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPad2Gen:
					iPad2Gen(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPhone4S:
					iPhone4S(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPad3Gen:
					iPad3Gen(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPhone5:
					iPhone5(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPodTouch5Gen:
					iPodTouch5Gen(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPhoneUnknown:
					iPhoneUnknown(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPadUnknown:
					iPadUnknown(this, new System.EventArgs());
					break;
				
				case iPhoneGeneration.iPodTouchUnknown:
					iPodTouchUnknown(this, new System.EventArgs());
					break;

				default:
					Unknown(this, new System.EventArgs());
					break;
			}
		}
		
	}

}