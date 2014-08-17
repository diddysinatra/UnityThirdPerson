// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/Camera")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets a Camera's CullingMask as an Int and a LayerMask.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("http://www.uscript.net/forum/viewtopic.php?f=21&t=1841")]

[FriendlyName("Get Camera CullingMask", "Gets a Camera's CullingMask as an Int and a LayerMask..")]
public class hyenApp_GetCameraCullingMask : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Camera.")] Camera target,
		[FriendlyName("CullingMask", "The returned CullingMask of the target Camera.")] out int cullingMask,
		[FriendlyName("LayerMask", "The returned LayerMask of the target Camera.")] out LayerMask layerMask
	){
		cullingMask = target.cullingMask;
		//layerMask = (1 << cullingMask);
		layerMask = cullingMask;
		
	}
	
}
