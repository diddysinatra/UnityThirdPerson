// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Terrain")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Normalize position relative to the Terrain.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Normalize Position (Terrain)", "Converts a position to normalized terrain coordinates (in the range of 0 to 1).")]
public class hyenApp_NormalizePositionTerrain : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Position", "The target Position.")] Vector3 position,
		[FriendlyName("Terrain", "The target Terrain.")] Terrain terrain,
		[FriendlyName("Normalized", "The Normalized terrain coordinates.")] out Vector3 normalized
	) {
		Vector3 temp = (position - terrain.gameObject.transform.position);
		Vector3 coord;
		coord.x = temp.x / terrain.terrainData.size.x;
		coord.y = temp.y / terrain.terrainData.size.y;
		coord.z = temp.z / terrain.terrainData.size.z;
		
		normalized = coord;
		
	}
	
}
