// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Conditions/Comparison")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Checks to see if a GameObject has the specified Component(s) Active.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("GameObject Has Component Active", "Checks to see if a GameObject has the specified Component(s) Active.")]
public class hyenApp_GameObjectHasComponentActive : uScriptLogic {

	private bool m_AllComponentsMatched = false;
	private bool m_NoComponentsMatched  = true;
	
	[FriendlyName("Has All Components Active")] public bool HasAllTags { get { return m_AllComponentsMatched; } }
	[FriendlyName("Has At Least One Component Active")] public bool HasTag { get { return !m_NoComponentsMatched; } }
	[FriendlyName("Does Not Have any Components Active")] public bool MissingTags { get { return m_NoComponentsMatched; } }

	public void In(
		[FriendlyName("GameObject", "The GameObject to check.")] GameObject gameObject,
		[FriendlyName("Components", "The Components to check for. Can attach multiple to check for multiple Components.")] string[] components
	) {
		m_AllComponentsMatched = true;
		m_NoComponentsMatched  = true;

		foreach(string component in components) {
			Component comp = gameObject.GetComponent( component );
			
			if (comp != null) {
				
				bool active = false;
				
				if (typeof(Behaviour).IsAssignableFrom(comp.GetType())) {
					active = ((Behaviour)comp).enabled;
				} else if (typeof(ParticleEmitter).IsAssignableFrom(comp.GetType())) {
					active = ((ParticleEmitter)comp).enabled;
				}
				
				if (!active) {
					m_AllComponentsMatched = false;
				} else {
					m_NoComponentsMatched = false;
				}
				
			}
			
		}
		
	}
	
}
