// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets The bounding volumes of the Target GameObject's collider and renderer.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Bounds", "Gets The bounding volumes of the Target GameObject's collider and renderer. If the Target GameObjects collider or renderer is null this node will create a new bounds that encapsulates its children's colliders or renderers.")]
public class hyenApp_GetBounds : uScriptLogic {
	
	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target GameObject")] GameObject Target,
		[FriendlyName("Collider Bounds", "The Collider Bounds of Target GameObject.")] out Bounds ColliderBounds,
		[FriendlyName("Renderer Bounds", "The Renderer Bounds of Target GameObject.")] out Bounds RendererBounds
	) {
		if (null != Target.collider) {
			ColliderBounds = Target.collider.bounds;
		} else {
			ColliderBounds = new Bounds(Target.transform.position, Vector3.zero);
			Component[] colliders = Target.GetComponentsInChildren<Collider>();
			foreach (Collider collider in colliders) {
				ColliderBounds.Encapsulate(collider.collider.bounds);
			}
			
		}
		
		if (null != Target.renderer) {
			RendererBounds = Target.renderer.bounds;
		} else {
			RendererBounds = new Bounds(Target.transform.position, Vector3.zero);
			Component[] meshes = Target.GetComponentsInChildren<MeshFilter>();
			foreach (MeshFilter mesh in meshes) {
				RendererBounds.Encapsulate(mesh.renderer.bounds);
			}
			
		}
		
	}
	
}
