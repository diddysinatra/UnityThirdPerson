// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the LayerMask for the target GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.uscript.net/forum/viewtopic.php?f=21&t=1841")]

[FriendlyName("Get LayerMask", "Gets the LayerMask for the target GameObject.")]
public class hyenApp_GetLayerMask : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The GameObject.")] GameObject target,
		[FriendlyName("LayerMask", "The returned LayerMask of the GameObject.")] out LayerMask layerMask
	){
		layerMask = (1 << target.layer);
		
	}
	
}
