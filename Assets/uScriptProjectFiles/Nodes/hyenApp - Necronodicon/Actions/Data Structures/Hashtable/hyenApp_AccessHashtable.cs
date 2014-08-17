// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Data Structures/Hashtable")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Access the contents of a Hashtable.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Access Hashtable", "Access the contents of a Hashtable.")]
public class hyenApp_AccessHashtable : uScriptLogic {

	public bool Out { get { return true; } }
	
	[FriendlyName("At Key")]
	public void AtKey(
		[FriendlyName("Key", "The Key used to lookup the key value pair from are Hashtable.")] object Key,
		[FriendlyName("Hashtable", "The Hashtable that contains are Key and Value pairs.")] ref Hashtable Table,
		[FriendlyName("Value", "The selected Value.")] out object Value
	) {
		if (Table == null) {
			Table = new Hashtable();
		} else {
			Table = new Hashtable(Table);
		}
		
		if (!Table.ContainsKey(Key)) {
			uScriptDebug.Log("[Access Hashtable] Key not found in Hashtable.", uScriptDebug.Type.Error);
			Value = null;
		} else {
			Value = (object)Table[Key];
		}
	}

}