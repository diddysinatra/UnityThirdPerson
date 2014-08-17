// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Math/Curves")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Calculates a Vector3 list of points along Bezier curve.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Bezier Curve Vector3", "Calculates a Vector3 list of points along Bezier curve.")]
public class hyenApp_BezierCurveVector3 : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Start Point", "first term")] Vector3 p1,
		[FriendlyName("Start Curve", "second term")] Vector3 p2,
		[FriendlyName("End Curve", "third term")] Vector3 p3,
		[FriendlyName("End Point", "fourth term")] Vector3 p4,
		[FriendlyName("Segments", "The number of increments that will describe the curve.")] int s,
		[FriendlyName("Curve", "A list of points that describe the Bezier curve.")] out Vector3[] List,
		[FriendlyName("List Size", "The number of points in the curve list."), SocketState(false, false)] out int ListCount
	) {
		List<Vector3> list = new List<Vector3>();
		
		for(int i = 0; i <= s; i++) {
			float t = i / (float) s;
			float u = 1 - t;
			float tt = t * t;
			float uu = u * u;
			float uuu = uu * u;
			float ttt = tt * t;
			
			Vector3 p = uuu * p1;
			p += 3 * uu * t * p2;
			p += 3 * u * tt * p3;
			p += ttt * p4;
			
			list.Add(p);
		}
		
		List = list.ToArray();
		ListCount = List.Length;
		
	}
	
}
