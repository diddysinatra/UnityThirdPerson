// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Bounds")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Creates new Bounds with a given Center and total Size. Bound extents will be half the given size.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Components (Bounds)", "Creates new Bounds with a given Center and total Size. Bound extents will be half the given size.")]
public class hyenApp_SetComponentsBounds : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Center", "Center value to use for the Output Vector.")] Vector3 Center,
		[FriendlyName("Size", "Size value to use for the Output Vector.")] Vector3 Size,
		[FriendlyName("Output Bounds", "Bounds variable built from the specified Center and Size.")] out Bounds OutputBounds
	) {
		OutputBounds = new Bounds(Center, Size);
		
	}

}