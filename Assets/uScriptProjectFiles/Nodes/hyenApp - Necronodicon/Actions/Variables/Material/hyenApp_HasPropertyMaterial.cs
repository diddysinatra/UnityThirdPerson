// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Checks if Material's shader has a property of a given name.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Has Property (Material)", "Checks if Material's shader has a property of a given name.")]
public class hyenApp_HasPropertyMaterial : uScriptLogic {

	private bool m_HasProperty = false;

	public bool True { get { return m_HasProperty; } }
	public bool False { get { return !m_HasProperty; } }
	
	[FriendlyName("In")] public void In(
		[FriendlyName("Material", "The Material to chek for Property Name.")] Material material,
		[FriendlyName("Property Name", "Property Name to check.")] string propertyName
	) {
		m_HasProperty = material.HasProperty(propertyName);
		
	}
	
}
