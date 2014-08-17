// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/LightmapData")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Iterate through each LightmapData in a LightmapData List (uScript events must drive each iteration)")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("For Each In List (LightmapData)", "Iterates through a list, one item at a time, and returns the current item.\n\nNote: uScript events must drive each iteration.")]
public class hyenApp_ForEachListLightmapData : uScriptLogic {

	private LightmapData[] m_List = null;
	private int m_CurrentIndex = 0;
	private bool m_Done = false;
	private bool m_ImmediateDone = false;

	public bool Immediate {
		get { 
			if (!m_ImmediateDone) {
				m_ImmediateDone = true;
				return true; 
			}
			return false;
		} 
	}
	
	[FriendlyName("Done Iterating")]
	public bool Done { get { return m_Done; } }

	[FriendlyName("Iteration")]
	public bool Iteration { get { return m_List != null && m_CurrentIndex <= m_List.Length && m_CurrentIndex != 0; } }

	[FriendlyName("Reset")]
	public void Reset(LightmapData[] List, out LightmapData Value) {
		Value = new LightmapData();
		
		m_List = List;
		m_CurrentIndex = 0;
		m_Done = false;

		m_ImmediateDone = false;
	}

	public void In(
		[FriendlyName("List", "The list to iterate over.")] LightmapData[] List,
		[FriendlyName("Current", "The item for the current loop iteration.")] out LightmapData Value
	) {
		if (m_List == null) {
			m_List = List;
			m_CurrentIndex = 0;
			m_Done = false;
		}

		m_ImmediateDone = !(m_List != null && m_CurrentIndex == 0);
		Value = new LightmapData();
		if (m_List != null) {
			if (m_CurrentIndex < m_List.Length) {
				Value = m_List[m_CurrentIndex];
			}
			m_CurrentIndex++;

			// done iterating
			if (m_CurrentIndex > m_List.Length) {
				m_List = null;
				m_Done = true;
			}
		}
	}
	
}
