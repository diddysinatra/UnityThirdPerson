// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Animation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Fades the animation with name animation in over a period of time seconds and fades other animations out.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Animation Cross Fade", "Fades the animation with name animation in over a period of time seconds and fades other animations out. \n\nIf the animation is not set to be looping it will be stopped and rewinded after playing.")]
public class hyenApp_AnimationCrossFade : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target GameObject to Cross Fade animations with.")] GameObject target,
		[FriendlyName("Animation", "The Animation name you want to Cross Fade to on the Target GameObject.")] string animation,
		[FriendlyName("Fade Length", "The period of time in seconds that the Cross Fade will take."), DefaultValue(0.3F), SocketState(false, false)] float fadeLength,
		[FriendlyName("Play Mode ", "if mode is PlayMode.StopSameLayer, animations in the same layer as animation will be faded out while animation is faded in. if mode is PlayMode.StopAll, all animations will be faded out while animation is faded in."), SocketState(false, false)] PlayMode playMode 
	) {
		target.animation.CrossFade(animation, fadeLength, playMode);
		
	}
	
}
