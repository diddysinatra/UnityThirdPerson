// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/NavMeshAgent")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip( "Sets the components of a NavMeshAgent.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (NavMeshAgent)", "Sets the components of a NavMeshAgent.")]
public class hyenApp_GetComponentsNavMeshAgent : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Agent", "The NavMeshAgent agent.")] NavMeshAgent agent,
		[FriendlyName("Destination", "The Destination to navigate towards.")] out Vector3 destination,
		[FriendlyName("Stopping Distance", "Stop within this distance from the target position.")] out float stoppingDistance,
		[FriendlyName("Velocity", "The current velocity of the NavMeshAgent component.")] out Vector3 velocity,
		[FriendlyName("Next Position", "The next position on the path.")] out Vector3 nextPosition,
		[FriendlyName("Steering Target", "The current steering target - usually the next corner or end point of the current path. (Read Only)")] out Vector3 steeringTarget,
		[FriendlyName("Desired Velocity", "The  desired velocity of the agent including any potential contribution from avoidance. (Read Only)")] out Vector3 desiredVelocity,
		[FriendlyName("Remaining Distance", "Remaining distance along the current path - or infinity when not known. (Read Only)")] out float remainingDistance,
		[FriendlyName("Base Offset", "The relative vertical displacement of the owning GameObject.")] out float baseOffset,
		[FriendlyName("Is On Off Mesh Link", "Is agent currently positioned on an OffMeshLink. (Read Only)")] out bool isOnOffMeshLink,
		[FriendlyName("Current Off Mesh Link Data", "The current OffMeshLinkData.")] out OffMeshLinkData currentOffMeshLinkData,
		[FriendlyName("Auto Traverse Off Mesh Link", "Automate movement onto and off of OffMeshLinks.")] out bool autoTraverseOffMeshLink,
		[FriendlyName("Auto Repath", "Attempt to acquire a new path if the existing path becomes invalid or if the agent reaches the end of a partial and stale path.")] out bool autoRepath,
		[FriendlyName("Has Path", "Does the agent currently have a path. (Read Only)")] out bool hasPath,
		[FriendlyName("Path Pending", "A path is being computed, but not yet ready. (Read Only)")] out bool pathPending,
		[FriendlyName("Is Path Stale", "Is the current path stale. (Read Only) \n\nWhen true, the path may no longer be valid or optimal. This flag will be set if: there are any changes to the walkableMask, if any OffMeshLink is enabled or disabled, or if the costs for the NavMeshLayers have been changed.")] out bool isPathStale,
		[FriendlyName("Path Status", "Query the state of the current path.")] out NavMeshPathStatus pathStatus,
		[FriendlyName("Path", "Set or get a copy of the current path.")] out NavMeshPath path,
		[FriendlyName("Walkable Mask", "Specifies which NavMesh layers are passable (bitfield). Changing walkableMask will make the path stale (see isPathStale)")] out int walkableMask,
		[FriendlyName("Speed", "Maximum movement speed.")] out float speed,
		[FriendlyName("Angular Speed", "Maximum rotation speed in (deg/s).")] out float angularSpeed,
		[FriendlyName("Acceleration", "Maximum acceleration.")] out float acceleration,
		[FriendlyName("Update Position", "Should the agent update the transform position.")] out bool updatePosition,
		[FriendlyName("Update Rotation", "Should the agent update the transform orientation.")] out bool updateRotation,
		[FriendlyName("Radius", "Agent avoidance radius.")] out float radius,
		[FriendlyName("Height", "Agent height.")] out float height,
		[FriendlyName("Obstacle Avoidance Type", "The level of quality of avoidance.")] out ObstacleAvoidanceType obstacleAvoidanceType
	){
		destination = agent.destination;
		stoppingDistance = agent.stoppingDistance;
		velocity = agent.velocity;
		nextPosition = agent.nextPosition;
		steeringTarget = agent.steeringTarget;
		desiredVelocity = agent.desiredVelocity;
		remainingDistance = agent.remainingDistance;
		baseOffset = agent.baseOffset;
		isOnOffMeshLink = agent.isOnOffMeshLink;
		currentOffMeshLinkData = agent.currentOffMeshLinkData;
		autoTraverseOffMeshLink = agent.autoTraverseOffMeshLink;
		autoRepath = agent.autoRepath;
		hasPath = agent.hasPath;
		pathPending = agent.pathPending;
		isPathStale = agent.isPathStale;
		pathStatus = agent.pathStatus;
		path = agent.path;
		walkableMask = agent.walkableMask;
		speed = agent.speed;
		angularSpeed = agent.angularSpeed;
		acceleration = agent.acceleration;
		updatePosition = agent.updatePosition;
		updateRotation = agent.updateRotation;
		radius = agent.radius;
		height = agent.height;
		obstacleAvoidanceType = agent.obstacleAvoidanceType;
		
	}
	
}
