// uScript Event Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[NodePath("Actions/Variables/Lists")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Converts a Object variable into a List.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Convert Object To List", "Converts an Object variable into a List.")]
public class hyenApp_ConvertObjectToList : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Target", "The Target variable to be converted.")] object Target,
		[FriendlyName("AudioClip List", "The Target variable represented as a AudioClip list.")] out AudioClip[] AudioClipList,
		[FriendlyName("Camera List", "The Target variable represented as a Camera list.")] out Camera[] CameraList,
		[FriendlyName("Color List", "The Target variable represented as a Color list.")] out Color[] ColorList,
		[FriendlyName("ContactPoint List", "The Target variable represented as a ContactPoint list.")] out ContactPoint[] ContactPointList,
		[FriendlyName("Float List", "The Target variable represented as a floating-point list.")] out float[] FloatList,
		[FriendlyName("GameObject List", "The Target variable represented as an GameObject list.")] out GameObject[] GameObjectList,
		[FriendlyName("Int List", "The Target variable represented as an integer list.")] out int[] IntList,
		[FriendlyName("Object List", "The Target variable represented as a Object list.")] out object[] ObjectList,
		[FriendlyName("Rect List", "The Target variable represented as a Rect list.")] out Rect[] RectList,
		[FriendlyName("String List", "The Target variable represented as a string list.")] out string[] StringList,
		[FriendlyName("Vector2 List", "The Target variable represented as a Vector2 list.")]out Vector2[] Vector2List,
		[FriendlyName("Vector3 List", "The Target variable represented as a Vector3 list.")]out Vector3[] Vector3List,
		[FriendlyName("Vector4 List", "The Target variable represented as a Vector4 list.")]out Vector4[] Vector4List,
		[FriendlyName("List Size", "The number of items in the list after the conversion has taken place.")] out int ListCount
	) {
		AudioClipList = new AudioClip[0];
		CameraList = new Camera[0];
		ColorList = new Color[0];
		ContactPointList = new ContactPoint[0];
		FloatList = new float[0];
		GameObjectList = new GameObject[0];
		IntList = new int[0];
		ObjectList = new object[0];
		RectList = new Rect[0];
		StringList = new string[0];
		Vector2List = new Vector2[0];
		Vector3List = new Vector3[0];
		Vector4List = new Vector4[0];
		ListCount = 0;
		
		if (Target is AudioClip[]) { // Convert from AudioClip List
			AudioClipList = (AudioClip[])Target;
			ListCount = AudioClipList.Length;
		} else if (Target is Camera[]) { // Convert from Camera List
			CameraList = (Camera[])Target;
			ListCount = CameraList.Length;
		} else if (typeof(Color[]) == Target.GetType()) { // Convert from Color List
			ColorList = (Color[])Target;
			ListCount = ColorList.Length;
		} else if (Target is ContactPoint[]) { // Convert from ContactPoint List
			ContactPointList = (ContactPoint[])Target;
			ListCount = ContactPointList.Length;
		} else if (Target is float[]) { // Convert from float List
			FloatList = (float[])Target;
			ListCount = FloatList.Length;
		} else if (Target is GameObject[]) { // Convert from GameObject List
			GameObjectList = (GameObject[])Target;
			ListCount = GameObjectList.Length;
		} else if (Target is int[]) { // Convert from int List
			IntList = (int[])Target;
			ListCount = IntList.Length;
		} else if (Target is Rect[]) { // Convert from Rect List
			RectList = (Rect[])Target;
			ListCount = RectList.Length;
		} else if (Target is string[]) { // Convert from string List
			StringList = (string[])Target;
			ListCount = StringList.Length;
		} else if (Target is Vector2[]) { // Convert from Vector2 List
			Vector2List = (Vector2[])Target;
			ListCount = Vector2List.Length;
		} else if (Target is Vector3[]) { // Convert from Vector3 List
			Vector3List = (Vector3[])Target;
			ListCount = Vector3List.Length;
		} else if (Target is Vector4[]) { // Convert from Vector4 List
			Vector4List = (Vector4[])Target;
			ListCount = Vector4List.Length;
		} else if (Target is object[]) { // Convert from object List (Object is a fallback list type...)
			ObjectList = (object[])Target;
			ListCount = ObjectList.Length;
		} else {
			uScriptDebug.Log("[Convert Object To List] type of"+ Target.GetType() +" not supported in Target.", uScriptDebug.Type.Error);
		}
		
	}

}