// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Input")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Filters the output based on the state of a Mouse Button pressed down, held, or released.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Input Mouse Button Filter", "Filters the output based on the state of a Mouse Button pressed down, held, or released. \n\nButton values are 0 for left button, 1 for right button, 2 for the middle button.")]
public class hyenApp_InputMouseButtonFilter : uScriptLogic {

	public bool m_InputHeld = false;
	public bool m_InputDown = false;
	public bool m_InputUp = false;

	[FriendlyName("Mouse Button Held")]
	public bool KeyHeld { get { return m_InputHeld; } }

	[FriendlyName("Mouse Button Down")]
	public bool KeyDown { get { return m_InputDown; } }

	[FriendlyName("Mouse Button Up")]
	public bool KeyUp { get { return m_InputUp; } }

	public void In(
		[FriendlyName("Mouse Button", "The Mouse Button index that identifies the mouse button, you want to get. (this value is clamped between 0 and 2)")] int index
	) {
		int clampedIndex = Mathf.Clamp(index, 0, 2);
		m_InputDown = Input.GetMouseButtonDown(clampedIndex);
		m_InputHeld = Input.GetMouseButton(clampedIndex);
		m_InputUp = Input.GetMouseButtonUp(clampedIndex);
		
	}
	
}
