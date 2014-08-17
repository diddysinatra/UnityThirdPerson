// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GameObjects")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Test whether a Camera's view contains an GameObject regardless of whether it is rendered or not.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Is Visible From Camera", "Test whether a Camera's view contains an GameObject regardless of whether it is rendered or not.")]
public class hyenApp_IsVisibleFromCamera : uScriptLogic {

	private bool m_IsVisible;
	
	public bool Out { get { return true; } }
	
	[FriendlyName("Visible")]
	public bool Visible { get { return m_IsVisible; } }
	
	[FriendlyName("Not Visible")]
	public bool NotVisible { get { return !m_IsVisible; } }
	
	public void In(
		[FriendlyName("Target", "The Target GameObject to check for in the Camera's view frustum.")] GameObject target,
		[FriendlyName("Camera", "The Camera used to CalculateFrustrumPlanes to test whether the Camera's view contains the Target GameObject.")] Camera camera
	) {
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
		
		Bounds rendererBounds;
		
		if (null != target.renderer) {
			rendererBounds = target.renderer.bounds;
		} else {
			rendererBounds = new Bounds(target.transform.position, Vector3.zero);
			Component[] meshes = target.GetComponentsInChildren<MeshFilter>();
			foreach (MeshFilter mesh in meshes) {
				rendererBounds.Encapsulate(mesh.renderer.bounds);
			}
			
		}
		
		if (GeometryUtility.TestPlanesAABB(planes, rendererBounds)) {
			m_IsVisible = true;
		} else {
			m_IsVisible = false;
		}
		
	}
	
}
