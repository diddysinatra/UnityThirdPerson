// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/Material")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Activate the given pass for rendering.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Set Pass (Material)", "Activate the given pass for rendering. \n\nPass indices start from zero and go up to (but not including) the material's Pass Count. \n\nThis is mostly used in direct drawing code using GL class (Unity Pro only). For example, Image Effects use materials for implementing screen post-processing. For each pass in the material they activate the pass and draw a fullscreen quad. \n\nIf Set Pass node returns false, you should not render anything.")]
public class hyenApp_SetPassMaterial : uScriptLogic {
	
	private bool m_HasPass = false;
	
	public bool True { get { return m_HasPass; } }
	public bool False { get { return !m_HasPass; } }

	public void In(
		[FriendlyName("Material", "The Material to set the given Pass for rendering.")] ref Material material,
		[FriendlyName("Pass", "The Pass index to be set to the Material.")] int pass
	) {
		m_HasPass = material.SetPass(pass);
		
	}
	
}
