// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/AudioClip")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of a Collider variable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (AudioClip)", "Gets the components of a Collider variable. \n\nAn AudioClip stores the audio file either compressed as ogg vorbis or uncompressed. AudioClips are referenced and used by AudioSources to play sounds.")]
public class hyenApp_GetComponentsAudioClip : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("AudioClip", "A container variable for audio data.")] AudioClip audioClip,
		[FriendlyName("Length", "The length of the audio clip in seconds.")] out float length,
		[FriendlyName("Samples", "The length of the audio clip in samples.")] out int samples,
		[FriendlyName("Channels", "Channels in audio clip.")] out int channels,
		[FriendlyName("Frequency", "Sample frequency.")] out int frequency,
		[FriendlyName("Is Ready", "Is a streamed audio clip ready to play? \n\nIf the AudioClip is downloading from a web site, this returns if enough data has been downloaded so playback should be able to start without interruptions. For AudioClips not associated with a web stream, this value always returns true.")] out bool isReadyToPlay,
		[FriendlyName("Name", "The name of the object. \n\nComponents share the same name with the game object and all attached components.")] out string name,
		[FriendlyName("Hide Flags", "Should the object be hidden, saved with the scene or modifiable by the user?")] out HideFlags hideFlags
	) {
		length = audioClip.length;
		samples = audioClip.samples;
		channels = audioClip.channels;
		frequency = audioClip.frequency;
		isReadyToPlay = audioClip.isReadyToPlay;
		name = audioClip.name;
		hideFlags = audioClip.hideFlags;
		
	}
	
}
