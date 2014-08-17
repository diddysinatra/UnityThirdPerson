// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/LightmapData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a LightmapData variable as Texture2D values.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (LightmapData)", "Gets the components of a LightmapData variable as Texture2D values.")]
public class hyenApp_GetComponentsLightmapData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("LightmapData", "The input LightmapData to get components of.")] LightmapData InputLightmapData,
		[FriendlyName("LightmapFar", "The LightmapFar value of the Input LightmapData.")] out Texture2D LightmapFar,
		[FriendlyName("LightmapNear", "The LightmapNear value of the Input LightmapData.")] out Texture2D LightmapNear
	) {
		LightmapFar = InputLightmapData.lightmapFar;
		LightmapNear = InputLightmapData.lightmapNear;
		
	}
	
}