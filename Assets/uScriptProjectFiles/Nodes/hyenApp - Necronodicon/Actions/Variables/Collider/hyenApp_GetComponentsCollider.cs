// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Collider")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Collider variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (Collider)", "Gets the components of a Collider variable. \n\nThe base class of all colliders stores enabled, attachedRigidbody, isTrigger, material, sharedMaterial, & bounds.")]
public class hyenApp_GetComponentsCollider : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Collider", "The target Collider.")] Collider collider,
		[FriendlyName("Enabled", "Enabled Colliders will collide with other colliders, disabled Colliders won't.")] out bool enabled,
		[FriendlyName("Attached Rigidbody", "The rigidbody the collider is attached to.")] out Rigidbody attachedRigidbody,
		[FriendlyName("Is Trigger", "Is the collider a trigger?")] out bool isTrigger,
		[FriendlyName("Material", "The material used by the collider.")] out PhysicMaterial material,
		[FriendlyName("Shared Material", "The shared physic material of this collider.")] out PhysicMaterial sharedMaterial,
		[FriendlyName("Bounds", "The world space bounding volume of the collider.")] out Bounds bounds
	) {
		enabled = collider.enabled;
		attachedRigidbody = collider.attachedRigidbody;
		isTrigger = collider.isTrigger;
		material = collider.material;
		sharedMaterial = collider.sharedMaterial;
		bounds = collider.bounds;
		
	}
	
}
