//uScript Generated Code - Build 1.0.2594
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class EnemyMove : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.Single local_3_System_Single = (float) 0;
   UnityEngine.GameObject local_Line_of_Sight_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_Line_of_Sight_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Raycast logic_uScriptAct_Raycast_uScriptAct_Raycast_0 = new uScriptAct_Raycast( );
   System.Object logic_uScriptAct_Raycast_Start_0 = "";
   System.Object logic_uScriptAct_Raycast_End_0 = "";
   UnityEngine.LayerMask logic_uScriptAct_Raycast_layerMask_0 = 1;
   System.Boolean logic_uScriptAct_Raycast_include_0 = (bool) true;
   System.Boolean logic_uScriptAct_Raycast_showRay_0 = (bool) true;
   UnityEngine.GameObject logic_uScriptAct_Raycast_HitObject_0;
   System.Single logic_uScriptAct_Raycast_HitDistance_0;
   UnityEngine.Vector3 logic_uScriptAct_Raycast_HitLocation_0;
   UnityEngine.Vector3 logic_uScriptAct_Raycast_HitNormal_0;
   bool logic_uScriptAct_Raycast_NotObstructed_0 = true;
   bool logic_uScriptAct_Raycast_Obstructed_0 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_2 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_2 = "";
   System.Object[] logic_uScriptAct_Log_Target_2 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_2 = "";
   bool logic_uScriptAct_Log_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetChildrenByName logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_5 = new uScriptAct_GetChildrenByName( );
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_Target_5 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetChildrenByName_Name_5 = "Line of Sight";
   uScriptAct_GetChildrenByName.SearchType logic_uScriptAct_GetChildrenByName_SearchMethod_5 = uScriptAct_GetChildrenByName.SearchType.Matches;
   System.Boolean logic_uScriptAct_GetChildrenByName_recursive_5 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_GetChildrenByName_FirstChild_5;
   UnityEngine.GameObject[] logic_uScriptAct_GetChildrenByName_Children_5;
   System.Int32 logic_uScriptAct_GetChildrenByName_ChildrenCount_5;
   bool logic_uScriptAct_GetChildrenByName_Out_5 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenFound_5 = true;
   bool logic_uScriptAct_GetChildrenByName_ChildrenNotFound_5 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_4 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Line_of_Sight_UnityEngine_GameObject_previous != local_Line_of_Sight_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Line_of_Sight_UnityEngine_GameObject_previous = local_Line_of_Sight_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Line_of_Sight_UnityEngine_GameObject_previous != local_Line_of_Sight_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Line_of_Sight_UnityEngine_GameObject_previous = local_Line_of_Sight_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_4 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_4 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_4 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_4.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_4;
                  component.OnLateUpdate += Instance_OnLateUpdate_4;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_4;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_4 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_4;
               component.OnLateUpdate -= Instance_OnLateUpdate_4;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_4;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Raycast_uScriptAct_Raycast_0.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_2.SetParent(g);
      logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_5.SetParent(g);
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_4( );
   }
   
   void Instance_OnLateUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_4( );
   }
   
   void Instance_OnFixedUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_4( );
   }
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("627502f0-a925-48f7-be67-06b4b6b0221c", "Raycast", Relay_In_0)) return; 
         {
            {
               logic_uScriptAct_Raycast_Start_0 = owner_Connection_1;
               
            }
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_Line_of_Sight_UnityEngine_GameObject_previous != local_Line_of_Sight_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_Line_of_Sight_UnityEngine_GameObject_previous = local_Line_of_Sight_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_Raycast_End_0 = local_Line_of_Sight_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_Raycast_uScriptAct_Raycast_0.In(logic_uScriptAct_Raycast_Start_0, logic_uScriptAct_Raycast_End_0, logic_uScriptAct_Raycast_layerMask_0, logic_uScriptAct_Raycast_include_0, logic_uScriptAct_Raycast_showRay_0, out logic_uScriptAct_Raycast_HitObject_0, out logic_uScriptAct_Raycast_HitDistance_0, out logic_uScriptAct_Raycast_HitLocation_0, out logic_uScriptAct_Raycast_HitNormal_0);
         local_3_System_Single = logic_uScriptAct_Raycast_HitDistance_0;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Raycast_uScriptAct_Raycast_0.Obstructed;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript EnemyMove.uscript at Raycast.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ffef70ea-ad73-4005-a236-5d1e8236b762", "Log", Relay_In_2)) return; 
         {
            {
            }
            {
               List<System.Object> properties = new List<System.Object>();
               properties.Add((System.Object)local_3_System_Single);
               logic_uScriptAct_Log_Target_2 = properties.ToArray();
            }
            {
            }
         }
         logic_uScriptAct_Log_uScriptAct_Log_2.In(logic_uScriptAct_Log_Prefix_2, logic_uScriptAct_Log_Target_2, logic_uScriptAct_Log_Postfix_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript EnemyMove.uscript at Log.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_4()
   {
      if (true == CheckDebugBreak("75dd347e-80bc-45d3-9cbb-491844ab1f31", "Global Update", Relay_OnUpdate_4)) return; 
      Relay_In_5();
   }
   
   void Relay_OnLateUpdate_4()
   {
      if (true == CheckDebugBreak("75dd347e-80bc-45d3-9cbb-491844ab1f31", "Global Update", Relay_OnLateUpdate_4)) return; 
   }
   
   void Relay_OnFixedUpdate_4()
   {
      if (true == CheckDebugBreak("75dd347e-80bc-45d3-9cbb-491844ab1f31", "Global Update", Relay_OnFixedUpdate_4)) return; 
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8eef5c60-8412-4665-878e-7370be7d34f2", "Get Children By Name", Relay_In_5)) return; 
         {
            {
               logic_uScriptAct_GetChildrenByName_Target_5 = owner_Connection_1;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_5.In(logic_uScriptAct_GetChildrenByName_Target_5, logic_uScriptAct_GetChildrenByName_Name_5, logic_uScriptAct_GetChildrenByName_SearchMethod_5, logic_uScriptAct_GetChildrenByName_recursive_5, out logic_uScriptAct_GetChildrenByName_FirstChild_5, out logic_uScriptAct_GetChildrenByName_Children_5, out logic_uScriptAct_GetChildrenByName_ChildrenCount_5);
         local_Line_of_Sight_UnityEngine_GameObject = logic_uScriptAct_GetChildrenByName_FirstChild_5;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_Line_of_Sight_UnityEngine_GameObject_previous != local_Line_of_Sight_UnityEngine_GameObject || false == m_RegisteredForEvents )
            {
               //tear down old listeners
               
               local_Line_of_Sight_UnityEngine_GameObject_previous = local_Line_of_Sight_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetChildrenByName_uScriptAct_GetChildrenByName_5.Out;
         
         if ( test_0 == true )
         {
            Relay_In_0();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript EnemyMove.uscript at Get Children By Name.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "EnemyMove.uscript:3", local_3_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "68135684-4fe3-4155-871c-2be1f9fdee8d", local_3_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "EnemyMove.uscript:Line of Sight", local_Line_of_Sight_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "fc2c2375-2828-410c-b06a-7f89ed0c5543", local_Line_of_Sight_UnityEngine_GameObject);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.LatestMasterComponent.HasBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
