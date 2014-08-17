// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/TerrainData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Assign all splat values in the given Alphas map area.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Alphamaps (TerrainData)", "Assign all splat values in the given Alphas map area.")]
public class hyenApp_SetAlphamapsTerrainData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Target", "The Target TerrainData.")] TerrainData terrainData,
		[FriendlyName("X", "The X point.")] int x,
		[FriendlyName("Y", "The Y point.")] int y,
		[FriendlyName("Alphas", "The Alphas map area to set.")] float[,,] alphas
	) {
		terrainData.SetAlphamaps(x, y, alphas);
		
	}
}
