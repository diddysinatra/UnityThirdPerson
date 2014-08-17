// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/TerrainData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the height at a certain point x, y.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Height (TerrainData)", "Gets the height at a certain point x, y.")]
public class hyenApp_GetHeightTerrainData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Target", "The Target TerrainData.")] TerrainData terrainData,
		[FriendlyName("X", "The X point.")] int x,
		[FriendlyName("Y", "The Y point.")] int y,
		[FriendlyName("Height", "The height at a certain point x, y.")] out float height
	) {
		height = terrainData.GetHeight(x, y);
		
	}
	
}
