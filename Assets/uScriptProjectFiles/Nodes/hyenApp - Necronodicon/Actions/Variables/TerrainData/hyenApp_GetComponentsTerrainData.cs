// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/TerrainData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a TerrainData variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (TerrainData)*", "*Incomplete! \n\nGets the components of a TerrainData variable. \n\nThe TerrainData class stores heightmaps, detail mesh positions, tree instances, and terrain texture alpha maps.")]
public class hyenApp_GetComponentsTerrainData : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target TerrainData.")] TerrainData terrainData,
		[FriendlyName("Heightmap Width", "Width of the terrain in samples (Read Only).")] out int heightmapWidth,
		[FriendlyName("Heightmap Height", "Height of the terrain in samples (Read Only).")] out int heightmapHeight,
		[FriendlyName("Heightmap Resolution", "Resolution of the heightmap."), SocketState(false, false)] out int heightmapResolution,
		[FriendlyName("Heightmap Scale", "The size of each heightmap sample."), SocketState(false, false)] out Vector3 heightmapScale,
		[FriendlyName("Size", "The total size in world units of the terrain.")] out Vector3 size,
		[FriendlyName("Waving Grass Strength", "Strength of the waving grass in the terrain."), SocketState(false, false)] out float wavingGrassStrength,
		// WIP!
		[FriendlyName("Alphamap Layers", "Number of alpha map layers."), SocketState(false, false)] out int alphamapLayers,
		[FriendlyName("Alphamap Resolution", "Resolution of the alpha map."), SocketState(false, false)] out int alphamapResolution,
		[FriendlyName("Alphamap Width", "Width of the alpha map."), SocketState(false, false)] out int alphamapWidth,
		[FriendlyName("Alphamap Height", "Height of the alpha map."), SocketState(false, false)] out int alphamapHeight
		// WIP!
	) {
		heightmapWidth = terrainData.heightmapWidth;
		heightmapHeight = terrainData.heightmapHeight;
		heightmapResolution = terrainData.heightmapResolution;
		heightmapScale = terrainData.heightmapScale;
		size = terrainData.size;
		wavingGrassStrength = terrainData.wavingGrassStrength;
		// WIP!
		alphamapLayers = terrainData.alphamapLayers;
		alphamapResolution = terrainData.alphamapResolution;
		alphamapWidth = terrainData.alphamapWidth;
		alphamapHeight = terrainData.alphamapHeight;
		// WIP!
		
	}
	
}
