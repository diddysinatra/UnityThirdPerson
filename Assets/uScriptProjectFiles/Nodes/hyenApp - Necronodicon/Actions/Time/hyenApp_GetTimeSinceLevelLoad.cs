// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Time")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the time in seconds since the last level has been loaded.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Time Since Level Load", "Gets the time in seconds since the last level has been loaded.")]
public class hyenApp_GetTimeSinceLevelLoad : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Level Time", "Outputs the total number of seconds since the last level has been loaded.")] out float LevelTime
	) {
		LevelTime = Time.timeSinceLevelLoad;
		
	}

}