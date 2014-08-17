// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/TerrainData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Set an array of heightmap samples.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Heights (TerrainData)", "Set an array of heightmap samples.")]
public class hyenApp_SetHeightsTerrainData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Target", "The Target TerrainData.")] TerrainData terrainData,
		[FriendlyName("X", "The X point.")] int x,
		[FriendlyName("Y", "The Y point.")] int y,
		[FriendlyName("Heights", "The an array of heightmap samples to set.")] float[,] heights
	) {
		terrainData.SetHeights(x, y, heights);
		
	}
	
}
