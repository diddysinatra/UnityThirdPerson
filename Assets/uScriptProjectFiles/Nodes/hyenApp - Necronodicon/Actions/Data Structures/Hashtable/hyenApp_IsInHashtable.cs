// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Data Structures/Hashtable")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Determines whether the Hashtable contains a specific key or value.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Is In Hashtable", "Determines whether the Hashtable contains a specific key or value.")]
public class hyenApp_IsInHashtable : uScriptLogic {

	private bool m_InHashtable = false;

	[FriendlyName("In Hashtable")]
	public bool InHashtable { get { return m_InHashtable; } }

	[FriendlyName("Not In Hashtable")]
	public bool NotInHashtable { get { return !m_InHashtable; } }

	[FriendlyName("Contains Key")]
	public void ContainsKey(object Key, object Value, ref Hashtable Table) {
		if (Table == null) {
			Table = new Hashtable();
		} else {
			Table = new Hashtable(Table);
		}
		m_InHashtable = Table.ContainsKey(Key);
	}
	
	[FriendlyName("Contains Value")]
	public void ContainsValue(
		[FriendlyName("Key", "The Key to check for in the Hashtable.")] object Key,
		[FriendlyName("Value", "The Value to check for in the Hashtable.")] object Value,
		[FriendlyName("Hashtable", "The Hashtable to check.")] ref Hashtable Table
	) {
		if (Table == null) {
			Table = new Hashtable();
		} else {
			Table = new Hashtable(Table);
		}
		m_InHashtable = Table.ContainsValue(Value);
	}

}
