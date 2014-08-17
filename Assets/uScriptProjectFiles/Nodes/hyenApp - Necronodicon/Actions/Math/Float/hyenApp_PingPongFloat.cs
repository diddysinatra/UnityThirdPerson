// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/Math/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("PingPongs the returned float so it will move back and forth between 0 and Length.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("PingPong Float", "PingPongs the returned float so it will move back and forth between 0 and Length. \n\nThe returned value will never larger than length and never smaller than 0.")]
public class hyenApp_PingPongFloat : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("T", "The time to translate between 0 and Length.")] float T,
		[FriendlyName("Length", "The Length value.")] float Length,
		[FriendlyName("Result", "The returned value will move back and forth between 0 and Length.")] out float Result
	) {
		Result = Mathf.PingPong(T, Length);
		
	}
	
}
