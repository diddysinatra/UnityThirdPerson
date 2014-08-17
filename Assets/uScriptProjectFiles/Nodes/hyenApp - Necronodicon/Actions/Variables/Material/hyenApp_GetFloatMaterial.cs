// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get a Material's named float value.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Float (Material)", "Get a Material's named float value.")]
public class hyenApp_GetFloatMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material to get the Float property from.")] Material material,
		[FriendlyName("Property Name", "The float Property Name used to Get the Material's Float value.")] string propertyName,
		[FriendlyName("Float", "The Float component from the target Material's shader Property Name.")] out float Float
	) {
		Float = material.GetFloat(propertyName);
		
	}
	
}
