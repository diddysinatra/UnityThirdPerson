// uScript Action Node
// (C) 2010 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2011 by Detox Studios LLC")]
[NodeToolTip("Clamps a Vector2 variable between a min and a max value for the desired components and returns the resulting Vector2.")]
[NodeAuthor("Detox Studios LLC", "http://www.detoxstudios.com")]
[NodeHelp("http://www.uscript.net/docs/index.php?title=Node_Reference_Guide")]

[FriendlyName("Clamp Vector2", "Clamps Vector2 variable components between minimun and maximum values.")]
public class uScriptAct_ClampVector2 : uScriptLogic
{
   public bool Out { get { return true; } }

   public void In(
      [FriendlyName("Target", "The Vector2 to be clamped.")]
      Vector2 Target,
      
      [FriendlyName("Clamp X", "If True, the X component will be clamped.")]
      [SocketState(false, false)]
      bool ClampX,
      
      [FriendlyName("X Min", "The minimum value allowed for the X component.")]
      [SocketState(false, false)]
      float XMin,
      
      [FriendlyName("X Max", "The maximum value allowed for the X component.")]
      [SocketState(false, false)]
      float XMax,
      
      [FriendlyName("Clamp Y", "If True, the Y component will be clamped.")]
      [SocketState(false, false)]
      bool ClampY,
      
      [FriendlyName("Y Min", "The minimum value allowed for the Y component.")]
      [SocketState(false, false)]
      float YMin,
      
      [FriendlyName("Y Max", "The maximum value allowed for the Y component.")]
      [SocketState(false, false)]
      float YMax,
      
      [FriendlyName("Result", "The clamped Vector2 variable.")]
      out Vector2 Result
      )
   {
      if (ClampX)
      {
         Target.x = Mathf.Clamp(Target.x, XMin, XMax);
      }
      if (ClampY)
      {
         Target.y = Mathf.Clamp(Target.y, YMin, YMax);
      }

      Result = Target;
   }
}