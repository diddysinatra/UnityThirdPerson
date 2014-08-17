// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Data Structures/Hashtable")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Iterates through a Hashtable, one item at a time, and returns the current item.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("For Each In Hashtable", "Iterates through a Hashtable, one item at a time, and returns the current item.\n\nNote: uScript events must drive each iteration.")]
public class hyenApp_ForEachHashtable : uScriptLogic {
	
	private Hashtable m_table = null;
	private IDictionaryEnumerator m_enumerator = null;
	private DictionaryEntry m_entry;
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
	public bool Iteration { get { return m_table != null; } }

	[FriendlyName("Reset")]
	public void Reset(Hashtable Table, out object Key, out object Value) {
		Key = null;
		Value = null;
		m_table = Table;
		m_enumerator = m_table.GetEnumerator();
		m_Done = false;
		m_ImmediateDone = false;
	}

	public void In(
		[FriendlyName("Hashtable", "The Hashtable to iterate over.")] Hashtable Table,
		[FriendlyName("Current Key", "The Key for the current loop iteration.")] out object Key,
		[FriendlyName("Current Value", "The Value for the current loop iteration.")] out object Value
	) {
		if (m_table == null) {
			m_table = Table;
			m_enumerator = m_table.GetEnumerator();
			m_Done = false;
		}

		m_ImmediateDone = !(m_table != null);
		Key = null;
		Value = null;
		if (m_table != null) {
			if (m_enumerator.MoveNext()) {
				m_entry = (DictionaryEntry)m_enumerator.Current;
				Key = (object)m_entry.Key;
				Value = (object)m_entry.Value;
			} else {
				// done iterating
				m_table = null;
				m_Done = true;
			}
		}
		
	}

}
