// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get the value of Material's shader tag.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Tag (Material)", "Get the value of Material's shader tag.")]
public class hyenApp_GetTagMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material's to get the Value from its shader tag.")] Material material,
		[FriendlyName("Tag", "Tag name to get.")] string tag,
		[FriendlyName("Search Fallbacks", "If Search Fallbacks is true then this node will look for Tag in all subshaders and all fallbacks. If seachFallbacks is false then only the currently used subshader will be queried for the tag."), SocketState(false, false), DefaultValue(true)] bool searchFallbacks,
		[FriendlyName("Default Value", "If the Material's shader does not define the Tag, the Default Value is returned."), SocketState(false, false), DefaultValue("")] string defaultValue,
		[FriendlyName("Value", "The Value of Material's shader Tag.")] out string tagValue
	) {
		tagValue = material.GetTag(tag, searchFallbacks, defaultValue);
		
	}
	
}
