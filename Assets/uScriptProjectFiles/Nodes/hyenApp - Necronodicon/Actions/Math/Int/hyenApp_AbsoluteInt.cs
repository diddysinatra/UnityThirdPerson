// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/Math/Int")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns the absolute value of I.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Absolute Int", "Returns the absolute value of I.")]
public class hyenApp_AbsoluteInt : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("I")] int I,
		[FriendlyName("Result")] out int Result
	) {
		Result = Mathf.Abs(I);
	}
	
}
