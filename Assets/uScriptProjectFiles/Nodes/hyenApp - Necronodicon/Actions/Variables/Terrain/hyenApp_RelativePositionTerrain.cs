// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Terrain")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Relative position to the Terrain.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Relative Position (Terrain)", "Returns the Relative position to the Terrain's Heightmap and Alphamap.")]
public class hyenApp_RelativePositionTerrain : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Terrain", "The target Terrain.")] Terrain terrain,
		[FriendlyName("Position", "The target Position.")] Vector3 position,
		[FriendlyName("Heightmap Relative", "The Heightmap Relative terrain coordinates.")] out Vector3 heightmapRelative,
		[FriendlyName("Alphamap Relative", "The Alphamap Relative terrain coordinates.")] out Vector3 alphamapRelative
	) {
		Vector3 temp = (position - terrain.gameObject.transform.position);
		Vector3 coord;
		coord.x = temp.x / terrain.terrainData.size.x;
		//coord.y = temp.y / terrain.terrainData.size.y;
		coord.z = temp.z / terrain.terrainData.size.z;
		
		heightmapRelative = new Vector3((coord.x * terrain.terrainData.heightmapWidth), 0, (coord.z * terrain.terrainData.heightmapHeight));
		alphamapRelative = new Vector3((coord.x * terrain.terrainData.alphamapWidth), 0, (coord.z * terrain.terrainData.alphamapHeight));
		
	}
	
}
