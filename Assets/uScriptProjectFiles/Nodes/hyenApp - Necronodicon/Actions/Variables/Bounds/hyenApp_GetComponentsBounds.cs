// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Bounds")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Ray as Vector3 Center, Size, and Extents, Min, Max.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (Bounds)", "Gets the components of a Ray as Vector3 Center, Size, and Extents, Min, Max.")]
public class hyenApp_GetComponentsBounds : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Target", "The Target Bounds.")] Bounds Target,
		[FriendlyName("Center", "The center of the bounding box.")] out Vector3 Center,
		[FriendlyName("Size", "The total size of the box. This is always twice as large as the Extents. Size.x is the width, Size.y is the height and Size.z is the depth of the box.")] out Vector3 Size,
		[FriendlyName("Extents", "The extents of the box. This is always half of the Size."), SocketState(false, false)] out Vector3 Extents,
		[FriendlyName("Min", "The minimal point of the box. This is always equal to Center minus Extents."), SocketState(false, false)] out Vector3 Min,
		[FriendlyName("Max", "The maximal point of the box. This is always equal to Center plus Extents."), SocketState(false, false)] out Vector3 Max
	) {
		Center = Target.center;
		Size = Target.size;
		Extents = Target.extents;
		Min = Target.min;
		Max = Target.max;
		
	}
	
}
