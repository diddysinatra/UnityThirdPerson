// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Web/Download")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Download an AssetBundle from the specified URL.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Web AssetBundle", "Download an AssetBundle from the specified URL.")]
public class hyenApp_WebAssetBundle : uScriptLogic {

	private bool _Out;
	private bool _OutFinished;
	private bool _OutError;

	private WWW _www = null;

	[FriendlyName("Out")] public bool Out { get { return _Out; } }
	[FriendlyName("Finished")] public bool OutFinished { get { return _OutFinished; } }
	[FriendlyName("Error")] public bool OutError { get { return _OutError; } }

	public void In(
		[FriendlyName("URL", "The url to download")] string URL,
		[FriendlyName("Form Data", "A WWWForm instance containing the form data to post."), SocketState(false, false)] WWWForm Form,
		[FriendlyName("Result", "The downloaded data.")] out AssetBundle Result,
		[FriendlyName("Error", "Returns an error message if there was an error during the download."), SocketState(false, false)] out string Error
	) {
		_Out = true;
		_OutFinished = false;
		_OutError = false;

		if (Form == null) {
			_www = new WWW(URL);
		} else {
			_www = new WWW(URL, Form);
		}

		Result = null;
		Error = string.Empty;
	}

	[Driven]
	public bool Driven(out AssetBundle Result, out string Error) {
		_Out = false;

		Result = null;
		Error = string.Empty;

		if (_OutFinished == false) {
			if (_www.isDone) {
				Result = _www.assetBundle;
				_OutFinished = true;
				
				if (_www.error != null) {
					Error = _www.error;
					_OutError = true;
				}
				
			}
			
			return true;
		}

		return false;
	}

}
