// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Data Structures/Hashtable")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Modify a Hashtable by adding/removing the specified key and value pairs, or by clearing all elements.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Modify Hashtable", "Modify a Hashtable by adding/removing the specified key and value pairs, or by clearing all elements, If a key already exists the value will be updated.")]
public class hyenApp_ModifyHashtable : uScriptLogic {

	public bool Out { get { return true; } }
	
	[FriendlyName("Add To Hashtable")]
	public void AddToHashtable(object Key, object Value, ref Hashtable Table, out int Count) {
		if (Table == null) {
			Table = new Hashtable();
		} else {
			Table = new Hashtable(Table);
		}
		if (Table.ContainsKey(Key)) {
			Table[Key] = Value;
		} else {
			Table.Add(Key, Value);
		}
		Count = Table.Count;
	}

	[FriendlyName("Remove From Hashtable")]
	public void RemoveFromHashtable(object Key, object Value, ref Hashtable Table, out int Count) {
		if (Table == null) {
			Table = new Hashtable();
		} else {
			Table = new Hashtable(Table);
		}
		Table.Remove(Key);
		Count = Table.Count;
	}

	[FriendlyName("Clear Hashtable")]
	public void ClearHashtabl(
		[FriendlyName("Key", "The Key to add or remove from the Hashtable.")] object Key,
		[FriendlyName("Value", "The Value to add or remove from the Hashtable.")] object Value,
		[FriendlyName("Hashtable", "The Hashtable to modify.")] ref Hashtable Table,
		[FriendlyName("Count", "The remaining number of elements in the hashtable after the modification has taken place.")] out int Count
	) {
		if (Table == null) {
			Table = new Hashtable();
		} else {
			Table = new Hashtable(Table);
		}
		Table.Clear();
		Count = 0;
	}

}