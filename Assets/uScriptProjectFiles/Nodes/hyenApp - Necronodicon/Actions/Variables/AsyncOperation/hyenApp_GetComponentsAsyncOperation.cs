// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Variables/AsyncOperation")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Gets the components of an AsyncOperation.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Get Components (AsyncOperation)", "Gets the components of an AsyncOperation.")]
public class hyenApp_GetComponentsAsyncOperation : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Input AsyncOperation", "The input AsyncOperation to get components of.")] AsyncOperation InputAsyncOperation,
		[FriendlyName("Is Done", "Has the operation finished?")] out bool IsDone,
		[FriendlyName("Progress", "What's the operation's progress?")] out float Progress,
		[FriendlyName("Priority", "Priority lets you tweak in which order async operation calls will be performed.")] [SocketState(false, false)] out int Priority
	) {
		IsDone = InputAsyncOperation.isDone;
		Progress = InputAsyncOperation.progress;
		Priority = InputAsyncOperation.priority;
		
	}

}