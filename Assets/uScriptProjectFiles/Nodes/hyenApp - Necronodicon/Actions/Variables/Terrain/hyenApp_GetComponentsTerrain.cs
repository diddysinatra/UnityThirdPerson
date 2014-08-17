// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Terrain")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Terrain variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (Terrain)", "Gets the components of a Terrain variable. \n\nThe Terrain component renders the terrain.")]
public class hyenApp_GetComponentsTerrain : uScriptLogic {

	public bool Out { get { return true; } }

	public void In( 
		[FriendlyName("Target", "The Target Terrain.")] Terrain terrain,
		[FriendlyName("TerrainData", "The Terrain Data that stores heightmaps, terrain textures, detail meshes and trees.")] out TerrainData terrainData,
		[FriendlyName("Tree Distance", "The maximum distance at which trees are rendered. \n\nThe higher this is, the further the distance trees can be seen and the slower it will run."), SocketState(false, false)] out float treeDistance,
		[FriendlyName("Tree Billboard Distance", "Distance from the camera where trees will be rendered as billboards only. \n\nDecreasing this value improves performance but makes the transition look worse because the difference between billboards and trees will be more obvious."), SocketState(false, false)] out float treeBillboardDistance,
		[FriendlyName("Tree Cross Fade Length", "Total distance delta that trees will use to transition from billboard orientation to mesh orientation. \n\nDecreasing this value makes the transition happen faster. Setting it to 0 will produce a visible pop when switching from mesh to billboard representation."), SocketState(false, false)] out float treeCrossFadeLength,
		[FriendlyName("Tree Maximum Full LOD Count", "Maximum number of trees rendered at full LOD. \n\nThis is an easy setting to prevent too many trees being rendered at too high resolution in dense forests. Since there will be no fade if treeMaximumFullLODCount is exceeded you should tweak the treeBillboardDistance to not include unnecessary trees that are not being seen but, still rendered."), SocketState(false, false)] out int treeMaximumFullLODCount,
		[FriendlyName("Detail Object Distance", "Detail objects will be displayed up to this distance."), SocketState(false, false)] out float detailObjectDistance,
		[FriendlyName("Detail Object Density", "Density of detail objects. \n\nThis number goes from 0.0 to 1.0, with 1.0 being the original density, and lower numbers resulting in less detail objects being rendered."), SocketState(false, false)] out float detailObjectDensity,
		[FriendlyName("Heightmap Pixel Error", "An approximation of how many pixels the terrain will pop in the worst case when switching lod. \n\nA higher value reduces the number of polygons drawn."), SocketState(false, false)] out float heightmapPixelError,
		[FriendlyName("Heightmap Maximum LOD", "Lets you essentially lower the heightmap resolution used for rendering. \n\nThis can be used on low end cards to never display the highest lod terrain. A value of 0 means always showing highest detail. A value of 1 means the triangle count will be reduced to 1/4th. The heightmap resolution will be halved for width and height."), SocketState(false, false)] out int heightmapMaximumLOD,
		[FriendlyName("Basemap Distance", "Heightmap patches beyond basemap distance will use a precomputed low res basemap. \n\nThis improves performance for far away patches. Close up Unity renders the heightmap using splat maps by blending between any amount of provided terrain textures."), SocketState(false, false)] out float basemapDistance,
		[FriendlyName("Lightmap Index", "The index of the lightmap applied to this renderer."), SocketState(false, false)] out int lightmapIndex,
		[FriendlyName("Cast Shadows", "Should terrain cast shadows?"), SocketState(false, false)] out bool castShadows
	) {
		terrainData = terrain.terrainData;
		treeDistance = terrain.treeDistance;
		treeBillboardDistance = terrain.treeBillboardDistance;
		treeCrossFadeLength = terrain.treeCrossFadeLength;
		treeMaximumFullLODCount = terrain.treeMaximumFullLODCount;
		detailObjectDistance = terrain.detailObjectDistance;
		detailObjectDensity = terrain.detailObjectDensity;
		heightmapPixelError = terrain.heightmapPixelError;
		heightmapMaximumLOD = terrain.heightmapMaximumLOD;
		basemapDistance = terrain.basemapDistance;
		lightmapIndex = terrain.lightmapIndex;
		castShadows = terrain.castShadows;
		//editorRenderFlags = terrain.editorRenderFlags;
		
	}
	
}
