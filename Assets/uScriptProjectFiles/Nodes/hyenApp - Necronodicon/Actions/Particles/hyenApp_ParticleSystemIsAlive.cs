// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Particles")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Is the particle system done emitting particles and are all particles dead?")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("ParticleSystem Is Alive", "Outputs Dead if the particle system is done emitting particles and all particles are dead. Outputs Alive if the particle system is still emitting particles or any particles are still alive.")]
public class hyenApp_ParticleSystemIsAlive : uScriptLogic {

	private bool m_IsAlive;
	
	//public bool Out { get { return true; } }
	
	[FriendlyName("Alive")]
	public bool Alive { get { return m_IsAlive; } }
	
	[FriendlyName("Dead")]
	public bool Dead { get { return !m_IsAlive; } }
	
	public void In(
		[FriendlyName("Target", "The Target GameObject to check for particle life.")] GameObject target
	) {
		ParticleSystem particleSystem = target.GetComponent<ParticleSystem>();
		m_IsAlive = particleSystem.IsAlive();
		
	}
	
}
