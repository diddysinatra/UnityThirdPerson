// uScript Action Node
// (C) 2014 Detox Studios LLC

#if !UNITY_3_5 && !UNITY_4_0 && !UNITY_4_1 && !UNITY_4_2
using UnityEngine;
using System.Collections;

[NodePath("Actions/Physics (2D)")]

[NodeCopyright("Copyright 2014 by Detox Studios LLC")]
[NodeToolTip("Applies an Add Force 2D at the specified location for the Target GameObject.")]
[NodeAuthor("Detox Studios LLC", "http://www.detoxstudios.com")]
[NodeHelp("http://www.uscript.net/docs/index.php?title=Node_Reference_Guide")]

[FriendlyName("Add Force At Position (2D)", "Applies an Add Force 2D at the specified location for the Target GameObject. Target must have a 2D rigidbody component in order to recieve a force.")]
public class uScriptAct_AddForceAtPosition2D : uScriptLogic
{
   public bool Out { get { return true; } }

   public void In(
      [FriendlyName("Target", "GameObject to apply the force to.")]
      GameObject Target,
      
      [FriendlyName("Force", "The force to apply to the Target. The force is a Vector3, so it defines both the direction and magnitude of the force.")]
      Vector2 Force,

      [FriendlyName("Position", "The location of the Force as a Vector3.")]
      Vector2 ForcePosition,
      
      [FriendlyName("Scale", "A scale to multiply to the force (force x scale).")]
      [DefaultValue(0f), SocketState(false, false)]
      float Scale
      )
   {
		if  ( null != Target.rigidbody2D )
		{
         if (Scale != 0) { Force = Force * Scale; }

         Target.rigidbody2D.AddForceAtPosition(Force, ForcePosition);
		}
		else
		{
         uScriptDebug.Log("(Node - Add Force At Position (2D)) The specified Target GameObject does not have a rigidbody2D component, so no force could be added.", uScriptDebug.Type.Warning);
		}
		
      
   }
}

#endif