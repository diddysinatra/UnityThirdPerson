// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Copy properties from Source Material into the Target Material.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Copy Properties From (Material)", "Copy properties from Source Material into the Target Material.")]
public class hyenApp_CopyPropertiesFromMaterial : uScriptLogic {

	[FriendlyName("Out")] public bool Out { get { return true; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Target Material", "Properties from the Source Material will be copyed into the Target Material.")] ref Material targetMaterial,
		[FriendlyName("Source Material", "The Source Material to copy properties from.")] Material sourceMaterial
	) {
		targetMaterial.CopyPropertiesFromMaterial(sourceMaterial);
		
	}
	
}
