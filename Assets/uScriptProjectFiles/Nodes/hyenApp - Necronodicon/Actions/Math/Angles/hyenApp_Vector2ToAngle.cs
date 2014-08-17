// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Angles")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Converts a Vector2 into an Angle.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("Vector2 To Angle", "Converts a Vector2 into an Angle.")]
public class hyenApp_Vector2ToAngle : uScriptLogic {

	public bool Out { get { return true; } }

	public void In(
		[FriendlyName("Vector2", "The Vector2 direction you want to convert into an Angle.")] Vector2 direction,
		[FriendlyName("Angle", "The resulting Angle as an float value.")] out float angle,
		[FriendlyName("Int Angle", "The resulting Angle as an int value."), SocketState(false, false)] out int intAngle
	) {
		if (direction.x == 0){
			if (direction.y > 0) {
				angle = 90;
			} else if (direction.y < 0) {
				angle = 270;
			} else { 
				angle = 0;
			}
			
		} else if(direction.y == 0){
			if (direction.x > 0) {
				angle = 0;
			} else if (direction.x < 0) {
				angle = 180;
			} else {
				angle = 0;
			}
			
		} else {
			float h = Mathf.Sqrt(direction.x * direction.x + direction.y * direction.y);
			angle = Mathf.Asin(direction.y / h) * Mathf.Rad2Deg;
			
			if (direction.y > 0){
				if (direction.x < 0) angle = 180 - angle;
			} else {
				if (direction.x > 0) angle = 360 + angle;
				if (direction.x < 0) angle = 180 - angle;
			}
			
		}
		
		intAngle = System.Convert.ToInt32(angle);
		
	}
	
}
