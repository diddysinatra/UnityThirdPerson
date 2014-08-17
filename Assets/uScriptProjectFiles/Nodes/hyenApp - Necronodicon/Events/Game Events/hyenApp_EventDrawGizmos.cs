// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodeAutoAssignMasterInstance(true)]

[NodePath("Events/Game Events")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Fires an event signal OnDrawGizmos and OnDrawGizmosSelected.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Draw Gizmos", "Fires an event signal OnDrawGizmos and OnDrawGizmosSelected.\n\nOn DrawGizmos:\nIs called every frame. All gizmos rendered within OnDrawGizmos are pickable.\n\nOn DrawGizmosSelected:\nIs called only if the object the script is attached to is selected.")]
public class hyenApp_EventDrawGizmos : uScriptEvent {
	
	public delegate void uScriptEventHandler(object sender, System.EventArgs args);

	[FriendlyName("On DrawGizmos")] public event uScriptEventHandler DrawGizmos;
	[FriendlyName("On DrawGizmosSelected")] public event uScriptEventHandler DrawGizmosSelected;

	void OnDrawGizmos() {
		if ( DrawGizmos != null ) DrawGizmos(this, new System.EventArgs());
	}

	void OnDrawGizmosSelected() {
		if ( DrawGizmosSelected != null ) DrawGizmosSelected(this, new System.EventArgs());
	}
	
}
