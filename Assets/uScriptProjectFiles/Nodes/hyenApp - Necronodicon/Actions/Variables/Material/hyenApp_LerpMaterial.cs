// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Interpolate properties between two materials.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Lerp (Material)", "Makes all color and float values of the Target material interpolate from Start material to End material, based on Time. \n\nMost often you want the materials that are interpolated between to be the same (use the same shaders and textures) except for colors and floats. Then you use Lerp to blend between them.")]
public class hyenApp_LerpMaterial : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target material to interpolate properties between Start and End materials.")] ref Material targetMaterial,
		[FriendlyName("Start", "When Time is 0, all values are taken from the Start material.")] Material startMaterial,
		[FriendlyName("End", "When Time is 1, all values are taken from the End material.")] Material endMaterial,
		[FriendlyName("Time", "All color and float values of the Target material are interpolated from Start material to End material, based on Time.")] float time
	) {
		targetMaterial.Lerp(startMaterial, endMaterial, time);
		
	}
	
}
