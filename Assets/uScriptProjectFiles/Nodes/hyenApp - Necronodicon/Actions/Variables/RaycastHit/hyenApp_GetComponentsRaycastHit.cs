// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/RaycastHit")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a RaycastHit as Vector3.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components RaycastHit", "Gets the components of a RaycastHit as Vector3.")]
public class hyenApp_GetComponentsRaycastHit : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Input RaycastHit", "The input raycast hit to get components of.")] RaycastHit inputRaycastHit,
		
		[FriendlyName("Hit GameObject", "The GameObject that was hit by the raycast.")] out GameObject hitGameObject,
		[FriendlyName("Hit Distance", "The distance from the ray's origin to the impact point.")] out float hitDistance,
		[FriendlyName("Hit Location", "The impact point in world space where the ray hit the collider.")] out Vector3 hitLocation,
		[FriendlyName("Hit Normal", "The normal of the surface the ray hit.")] out Vector3 hitNormal,
		
		[FriendlyName("Barycentric Coordinate", "The barycentric coordinate of the triangle we hit.")] [SocketState(false, false)] out Vector3 barycentricCoordinate,
		[FriendlyName("Triangle Index", "The index of the triangle that was hit.")] [SocketState(false, false)] out int triangleIndex,
		[FriendlyName("Texture Coord", "The uv texture coordinate at the impact point.")] [SocketState(false, false)] out Vector2 textureCoord,
		[FriendlyName("Texture Coord 2", "The secondary uv texture coordinate at the impact point.")] [SocketState(false, false)] out Vector2 textureCoord2,
		[FriendlyName("Lightmap Coord", "The uv lightmap coordinate at the impact point.")] [SocketState(false, false)] out Vector2 lightmapCoord,
		[FriendlyName("Collider", "The Collider that was hit.")] [SocketState(false, false)] out Collider collider,
		[FriendlyName("Rigidbody", "The Rigidbody of the collider that was hit. If the collider is not attached to a rigidbody then it is null.")] [SocketState(false, false)] out Rigidbody rigidbody,
		[FriendlyName("Transform", "The Transform of the rigidbody or collider that was hit.")] [SocketState(false, false)] out Transform transform
	) {
		hitGameObject = inputRaycastHit.collider.gameObject;
		hitDistance = inputRaycastHit.distance;
		hitLocation = inputRaycastHit.point;
		hitNormal = inputRaycastHit.normal;
		
		barycentricCoordinate = inputRaycastHit.barycentricCoordinate;
		triangleIndex = inputRaycastHit.triangleIndex;
		textureCoord = inputRaycastHit.textureCoord;
		textureCoord2 = inputRaycastHit.textureCoord2;
		lightmapCoord = inputRaycastHit.lightmapCoord;
		collider = inputRaycastHit.collider;
		rigidbody = inputRaycastHit.rigidbody;
		transform = inputRaycastHit.transform;
	}

}
