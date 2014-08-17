// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/TerrainData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Get an array of heightmap samples..")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Heights (TerrainData)", "Get an array of heightmap samples..")]
public class hyenApp_GetHeightsTerrainData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Target", "The Target TerrainData.")] TerrainData terrainData,
		[FriendlyName("X", "The X point.")] int x,
		[FriendlyName("Y", "The Y point.")] int y,
		[FriendlyName("W", "The Width point.")] int w,
		[FriendlyName("L", "The Length point.")] int l,
		[FriendlyName("Heights", "The an array of heightmap samples.")] out float[,] heights
	) {
		heights = terrainData.GetHeights(x, y, w, l);
		
	}
	
}
