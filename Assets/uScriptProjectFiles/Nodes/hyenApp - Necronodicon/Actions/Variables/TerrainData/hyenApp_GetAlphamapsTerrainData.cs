// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/TerrainData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the alpha map samples..")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Alphamaps (TerrainData)", "Gets the alpha map at a position x, y given a width and height.")]
public class hyenApp_GetAlphamapsTerrainData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Target", "The Target TerrainData.")] TerrainData terrainData,
		[FriendlyName("X", "The X point.")] int x,
		[FriendlyName("Y", "The Y point.")] int y,
		[FriendlyName("W", "The Width point.")] int w,
		[FriendlyName("H", "The Height point.")] int h,
		[FriendlyName("Alphas", "The alpha map samples.")] out float[,,] alphas
	) {
		alphas = terrainData.GetAlphamaps(x, y, w, h);
		
	}
	
}
