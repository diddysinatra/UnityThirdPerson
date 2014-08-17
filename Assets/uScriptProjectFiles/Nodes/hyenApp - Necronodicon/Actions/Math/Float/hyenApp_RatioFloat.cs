// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns the ratio of the Position between the Min and Max as an Axis 0 to 1.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.uscript.net/forum/viewtopic.php?f=21&t=1841")]

[FriendlyName("Ratio Float", "Returns the ratio of the Position between the Min and Max as an Axis 0 to 1.")]
public class hyenApp_RatioFloat : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In(
		[FriendlyName("Position", "")] float position,
		[FriendlyName("Min", "")] float min,
		[FriendlyName("Max", "")] float max,
		[FriendlyName("Axis", "The resulting Axis ratio.")] out float result
	) {
		float percentage = position - min;
		float range = max - percentage;
		result = percentage / range;
		
	}
	
}
