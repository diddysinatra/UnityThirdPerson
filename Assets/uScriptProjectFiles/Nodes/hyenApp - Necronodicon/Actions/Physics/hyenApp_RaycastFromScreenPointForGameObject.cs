// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Physics")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Cast a ray from the specified screen location (in pixels) out into the scene for the unique tag, name and InstanceID of the attached GameObject.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Raycast From Screen Point For GameObject", "Cast a ray from the specified screen location (in pixels) out into the scene, gets all hits, and compares the unique InstanceID of the attached GameObject variables and outputs accordingly. Optionally you can compare by a GameObject's tag and/or name instead. \n\nCamera: The Camera GameObject to cast the ray from. \nPosition: The X and Y position (in pixels) to raycast from. Acceptable values are from the screen's minimum X and Y (0,0) to the maximum current X and Y screen resolution values (values outside this range will be capped). \nDistance: How far out to cast the ray. \nLayer Mask: A Layer mask that is used to selectively ignore colliders when casting a ray. \nInclude Masked Layers: If true the ray will test against the masked layers, if false it will test against all layers excluding the masked layers. \nShow Ray: If true the ray will be displayed as a line in the Scene view. \nInstance: The GameObject to compare. \nCompare By Tag: Whether or not to compare the GameObjects' tags instead of the objects themselves. \nCompare By Name: Whether or not to compare the GameObjects' names instead of the objects themselves. \nHit Distance: The distance along the ray that the hit occurred (if any). \nHit Location: The position of the hit (if any). \nHit Normal: The surface normal of the hit (if any).\n  \nPlease note, if Compare By Name and Compare By Tag are both checked, they both much match for the 'Same' signal to fire.")]
public class hyenApp_RaycastFromScreenPointForGameObject : uScriptLogic {
	
	private bool m_NotObstructed = false;
	private bool m_Obstructed = false;
	private bool m_CompareValue = false;

	public bool NotObstructed { get { return m_NotObstructed; } }
	
	public bool Obstructed { get { return m_Obstructed; } }

	public void In(
		Camera Camera,
		[FriendlyName("Screen Position")] Vector2 ScreenPosition,
		[FriendlyName("Distance"), SocketState(false, false), DefaultValue(100f)] float Distance,
		[FriendlyName("Layer Mask"), SocketState(false, false)] LayerMask layerMask,
		//TODO: Uncomment when array support is added
		//[FriendlyName("Layer Masks"), SocketState(false, false)] LayerMask[] layerMasks,
		[FriendlyName("Include Masked Layers"), DefaultValue(true), SocketState(false, false)] bool include,
		[FriendlyName("Show Ray"), SocketState(false, false)] bool showRay,
		[FriendlyName("Instance")] GameObject A,
		[FriendlyName("Compare By Tag"), SocketState(false, false)] bool CompareByTag,
		[FriendlyName("Compare By Name"), SocketState(false, false)] bool CompareByName,
		//[FriendlyName("Hit GameObject")] out GameObject HitObject,
		[FriendlyName("Hit Distance"), SocketState(false, false)] out float HitDistance,
		[FriendlyName("Hit Location")] out Vector3 HitLocation,
		[FriendlyName("Hit Normal"), SocketState(false, false)] out Vector3 HitNormal
	) {
		bool hitTrue = false;
		float tmpHitDistance = 0F;
		Vector3 tmpHitLocation = Vector3.zero;
		Vector3 tmpHitNormal = new Vector3(0, 1, 0);
		//GameObject tmpHitObject = null;
		//TODO: Remove the following line when array support is added
		//LayerMask[] layerMasks = new LayerMask[] { layerMask };

		Ray ray = Camera.ScreenPointToRay(ScreenPosition);

		if (Distance <= 0) Distance = Mathf.Infinity;
		float castDistance = Distance;
		
		/*
		//RaycastHit hit;
		int bitmask = 0;
		
		foreach (LayerMask mask in layerMasks) {
			bitmask |= 1 << mask;
		}
		
		if (!include) bitmask = ~bitmask;
		*/
		
		if (!include) layerMask = ~layerMask;

		if (true == showRay) {
			Debug.DrawLine(ray.origin, ray.origin + (ray.direction * castDistance));
		}
		
		RaycastHit[] hits;
		hits = Physics.RaycastAll(ray.origin, ray.direction, castDistance, layerMask);
		int i = 0;
		while (i < hits.Length) {
			RaycastHit hit = hits[i];
			GameObject B = hit.collider.gameObject;
			if (true == CompareByTag || CompareByName) {
				m_CompareValue = true;
   				if (true == CompareByTag) {
					m_CompareValue = m_CompareValue && A.tag == B.tag;
				}
				if (true == CompareByName) {
					m_CompareValue = m_CompareValue && A.name == B.name;
				}
			} else {
				m_CompareValue = A.GetInstanceID() == B.GetInstanceID();
			}
			if (true == m_CompareValue) {
				tmpHitDistance = hit.distance;
				tmpHitLocation = hit.point;
				//tmpHitObject = hit.collider.gameObject;
				tmpHitNormal = hit.normal;
				hitTrue = true;
				break;
			}
			 i++;
		}

		HitDistance = tmpHitDistance;
		HitLocation = tmpHitLocation;
		//HitObject = tmpHitObject;
		HitNormal = tmpHitNormal;

		m_Obstructed = hitTrue;
		m_NotObstructed = !m_Obstructed;
		
	}
	
}
