// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the Terrain component of the Target GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Terrain", "Gets the Terrain component of the Target GameObject.")]
public class hyenApp_GetTerrain : uScriptLogic {

	public bool Out { get { return true; } }
	
	public void In (
		[FriendlyName("Target", "The GameObject you wish to get the Terrain for.")] GameObject Target,
		[FriendlyName("Terrain", "The Terrain of the target GameObject.")] out Terrain targetTerrain
	) {
		if ( null != Target ) {
			targetTerrain = Target.GetComponent<Terrain>();
		} else {
			uScriptDebug.Log ("(Node - Get Terrain): The specified Target GameObject was null.", uScriptDebug.Type.Warning);
			targetTerrain = null;
		}
		
	}
	
}
