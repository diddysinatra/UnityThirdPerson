// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/String")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Returns the first index of characters in a string as a float, integer, and string.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get First Index Of", "Returns the first index of characters in a string as a float, integer, and string.")]
public class hyenApp_GetStringFirstIndexOf : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target string to get the Chars index of.")] string Target,
		[FriendlyName("Chars", "The characters you want to get the index of in the Target string.")] string Chars,
		[FriendlyName("Result", "The index of Chars in the Target string, expressed as an integer.")] out int IntIndex,
		[FriendlyName("Float Result", "The index of Chars in the Target string, expressed as a floating-point number."), SocketState(false, false)] out float FloatIndex,
		[FriendlyName("String Result", "The index of Chars in the Target string, expressed as a string."), SocketState(false, false)] out string StringIndex
	) {
		int indexInt = 0;
		float indexFloat = 0F;
		string indexString = "0";

		if (!string.IsNullOrEmpty(Target) && !string.IsNullOrEmpty(Chars)) {
			indexInt = Target.IndexOf(Chars);
			indexFloat = System.Convert.ToSingle(indexInt);
			indexString = indexInt.ToString();
		}

		IntIndex = indexInt;
		FloatIndex = indexFloat;
		StringIndex = indexString;
		
	}

}
