// uScript Action Node
// (C) 2011 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2011 by Detox Studios LLC")]
[NodeToolTip( "Adds two Vector3 variables together and returns the result.")]
[NodeAuthor("Detox Studios LLC", "http://www.detoxstudios.com")]
[NodeHelp("http://www.uscript.net/docs/index.php?title=Node_Reference_Guide#Add_Vector3")]

[FriendlyName("Add Vector3", "Adds Vector3 variables together and returns the result." +
 "\n\n[ A + B ]" +
 "\n\nIf more than one variable is connected to A, they will be added together before being added to B." +
 "\n\nIf more than one variable is connected to B, they will be added together before being added to A.")]
public class uScriptAct_AddVector3 : uScriptLogic
{
   public bool Out { get { return true; } }

   public void In(
      [FriendlyName("A", "The first variable or variable list.")]
      Vector3[] A,

      [FriendlyName("B", "The second variable or variable list.")]
      Vector3[] B,

      [FriendlyName("Result", "The Vector3 result of the operation.")]
      out Vector3 Result
      )
   {
      Vector3 aTotals = new Vector3(0, 0, 0);
      Vector3 bTotals = new Vector3(0, 0, 0);

      foreach (Vector3 currentA in A)
      {
         aTotals += currentA;
      }
      foreach (Vector3 currentB in B)
      {
         bTotals += currentB;
      }

      Result = aTotals + bTotals;
   }
}