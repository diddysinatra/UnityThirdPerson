// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/Lists/ContactPoint")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Iterate through each ContactPoint in a ContactPoint list (uScript events must drive each iteration).")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("For Each In List (ContactPoint)", "Iterates through a list, one item at a time, and returns the current item.\n\nNote: uScript events must drive each iteration.")]
public class hyenApp_ForEachListContactPoint : uScriptLogic {

	private ContactPoint[] m_List = null;
	private int m_CurrentIndex = 0;
	private bool m_Done = false;
	private bool m_ImmediateDone = false;

	// Output Sockets
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

	// Input Sockets and Node Parameters
	// Parameter Attributes are applied below in In()
	[FriendlyName("Reset")]
	public void Reset(ContactPoint[] ContactPointList, out ContactPoint go) {
		go = new ContactPoint();
		if (m_List == null) {
			uScriptDebug.Log("For Each List (ContactPoint) must go through 'Manual' input before 'Resetting'.", uScriptDebug.Type.Error);
			return;
		}

		if (ContactPointList.Length > 0) {
			m_List = ContactPointList;
		} else {
			m_List = null;
		}
		
		m_CurrentIndex = 0;
		m_Done = false;

		m_ImmediateDone = false;
	}

	public void In(
		[FriendlyName("List", "The list to iterate over.")]
		ContactPoint[] ContactPointList,

		[FriendlyName("Current", "The item for the current loop iteration.")]
		out ContactPoint go ) 
	{

		if (m_List == null) {
			if (ContactPointList.Length > 0) {
				m_List = ContactPointList;
			} else {
				m_List = null;
			}
			m_CurrentIndex = 0;
			m_Done = false;
		}

		m_ImmediateDone = !(m_List != null && m_CurrentIndex == 0);
		go = new ContactPoint();
		
		if (m_List != null) {
			if (m_CurrentIndex < m_List.Length) {
				go = m_List[m_CurrentIndex];
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