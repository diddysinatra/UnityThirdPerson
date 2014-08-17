// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/AnimationClip")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a AnimationClip variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (AnimationClip)", "Gets the components of a AnimationClip variable. \n\nAnimationClip stores keyframe based animations. \n\nAnimationClip is used by Animation to play back animations.")]
public class hyenApp_GetComponentsAnimationClip : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("AnimationClip", "A container variable for animation data.")] AnimationClip animationClip,
		[FriendlyName("Length", "Animation length in seconds. (Read Only)")] out float length,
		[FriendlyName("Frame Rate", "Frame rate at which keyframes are sampled. (Read Only) \n\nThis is the frame rate that was used in the animation program you used to create the animation or model.")] out float frameRate,
		[FriendlyName("Wrap Mode", "The default wrap mode used in the animation state.")] out WrapMode wrapMode,
		[FriendlyName("Local Bounds", "AABB of this Animation Clip in local space of Animation component that it is attached too. \n\nIt is precomputed on import for imported models/animations based on the meshes that this animation clip affects. This bounding box is specific to the mesh(es) that this clip is attached to during import, i.e. this means that it is calculated based on the file that is part of and on the 'Model' file if you're using Model@Animation notation.")] out Bounds localBounds,
		[FriendlyName("Name", "The name of the object. \n\nComponents share the same name with the game object and all attached components.")] out string name,
		[FriendlyName("Hide Flags", "Should the object be hidden, saved with the scene or modifiable by the user?")] out HideFlags hideFlags
	) {
		length = animationClip.length;
		frameRate = animationClip.frameRate;
		wrapMode = animationClip.wrapMode;
		localBounds = animationClip.localBounds;
		name = animationClip.name;
		hideFlags = animationClip.hideFlags;
		
	}
	
}
