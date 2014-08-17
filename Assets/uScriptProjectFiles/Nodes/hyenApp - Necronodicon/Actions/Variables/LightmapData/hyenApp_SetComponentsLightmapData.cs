// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/LightmapData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Sets a LightmapData to the defined LightmapFar and LightmapNear Texture2D component values.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Components (LightmapData)", "Sets a LightmapData to the defined LightmapFar and LightmapNear Texture2D component values.")]
public class hyenApp_SetComponentsLightmapData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("LightmapFar", "LightmapFar value to use for the Output LightmapData.")] Texture2D LightmapFar,
		[FriendlyName("LightmapNear", "LightmapNear value to use for the Output LightmapData.")] Texture2D LightmapNear,
		[FriendlyName("LightmapData", "LightmapData variable built from the specified LightmapFar and LightmapNear.")] out LightmapData OutputLightmapData
	) {
		OutputLightmapData = new LightmapData();
		OutputLightmapData.lightmapFar = LightmapFar;
		OutputLightmapData.lightmapNear = LightmapNear;
		
	}
	
}