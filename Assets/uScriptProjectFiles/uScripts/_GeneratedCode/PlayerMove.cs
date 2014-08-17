//uScript Generated Code - Build 1.0.2594
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class PlayerMove : uScriptLogic
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
   System.Single local_13_System_Single = (float) 0;
   System.Single local_5_System_Single = (float) 0;
   System.Single local_8_System_Single = (float) 0;
   UnityEngine.Vector3 local_Force_to_Add_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_input_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_maxSpeed_System_Single = (float) 5;
   System.Single local_moveSpeed_System_Single = (float) 20;
   UnityEngine.GameObject local_PlayerRigidBody_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_PlayerRigidBody_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_1 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_1 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_1 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_1 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_1 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_1 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_1 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_1 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRigidbodyVelocity logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_3 = new uScriptAct_GetRigidbodyVelocity( );
   UnityEngine.GameObject logic_uScriptAct_GetRigidbodyVelocity_Target_3 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_GetRigidbodyVelocity_Velocity_3;
   System.Single logic_uScriptAct_GetRigidbodyVelocity_Magnitude_3;
   bool logic_uScriptAct_GetRigidbodyVelocity_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_7 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_7 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_7 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_7 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_7;
   bool logic_uScriptAct_SetComponentsVector3_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_10 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_10 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_10 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_10;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_14 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_14 = "";
   System.Object[] logic_uScriptAct_Log_Target_14 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_14 = "";
   bool logic_uScriptAct_Log_Out_14 = true;
   
   //event nodes
   System.Single event_UnityEngine_GameObject_Horizontal_0 = (float) 0;
   System.Single event_UnityEngine_GameObject_Vertical_0 = (float) 0;
   System.Boolean event_UnityEngine_GameObject_Fire1_0 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Fire2_0 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Fire3_0 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Jump_0 = (bool) false;
   System.Single event_UnityEngine_GameObject_MouseX_0 = (float) 0;
   System.Single event_UnityEngine_GameObject_MouseY_0 = (float) 0;
   System.Single event_UnityEngine_GameObject_MouseScrollWheel_0 = (float) 0;
   System.Single event_UnityEngine_GameObject_WindowShakeX_0 = (float) 0;
   System.Single event_UnityEngine_GameObject_WindowShakeY_0 = (float) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   UnityEngine.Vector3 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_force_12 = new Vector3( );
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_PlayerRigidBody_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_PlayerRigidBody_UnityEngine_GameObject = GameObject.Find( "Player" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_PlayerRigidBody_UnityEngine_GameObject_previous != local_PlayerRigidBody_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_PlayerRigidBody_UnityEngine_GameObject_previous = local_PlayerRigidBody_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_PlayerRigidBody_UnityEngine_GameObject_previous != local_PlayerRigidBody_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_PlayerRigidBody_UnityEngine_GameObject_previous = local_PlayerRigidBody_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_ManagedInput component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_ManagedInput>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_ManagedInput>();
               }
               if ( null != component )
               {
                  component.OnInputEvent += Instance_OnInputEvent_0;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_ManagedInput component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_ManagedInput>();
            if ( null != component )
            {
               component.OnInputEvent -= Instance_OnInputEvent_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_1.SetParent(g);
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_3.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_7.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_10.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_14.SetParent(g);
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
   
   void Instance_OnInputEvent_0(object o, uScript_ManagedInput.CustomEventBoolArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_Horizontal_0 = e.Horizontal;
      event_UnityEngine_GameObject_Vertical_0 = e.Vertical;
      event_UnityEngine_GameObject_Fire1_0 = e.Fire1;
      event_UnityEngine_GameObject_Fire2_0 = e.Fire2;
      event_UnityEngine_GameObject_Fire3_0 = e.Fire3;
      event_UnityEngine_GameObject_Jump_0 = e.Jump;
      event_UnityEngine_GameObject_MouseX_0 = e.MouseX;
      event_UnityEngine_GameObject_MouseY_0 = e.MouseY;
      event_UnityEngine_GameObject_MouseScrollWheel_0 = e.MouseScrollWheel;
      event_UnityEngine_GameObject_WindowShakeX_0 = e.WindowShakeX;
      event_UnityEngine_GameObject_WindowShakeY_0 = e.WindowShakeY;
      //relay event to nodes
      Relay_OnInputEvent_0( );
   }
   
   void Relay_OnInputEvent_0()
   {
      if (true == CheckDebugBreak("8a1d6ccb-afce-4767-9681-de57754f7244", "Managed Input Events", Relay_OnInputEvent_0)) return; 
      local_13_System_Single = event_UnityEngine_GameObject_Horizontal_0;
      local_8_System_Single = event_UnityEngine_GameObject_Vertical_0;
      Relay_In_3();
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9e397fe9-e67b-4f70-904e-31bcc4060c1d", "Compare Float", Relay_In_1)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_1 = local_5_System_Single;
               
            }
            {
               logic_uScriptCon_CompareFloat_B_1 = local_maxSpeed_System_Single;
               
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_1.In(logic_uScriptCon_CompareFloat_A_1, logic_uScriptCon_CompareFloat_B_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_1.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ed5b9bf8-d5b9-4c68-9708-3a1fd804009a", "Get Rigidbody Velocity", Relay_In_3)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_PlayerRigidBody_UnityEngine_GameObject_previous != local_PlayerRigidBody_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_PlayerRigidBody_UnityEngine_GameObject_previous = local_PlayerRigidBody_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_GetRigidbodyVelocity_Target_3 = local_PlayerRigidBody_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_3.In(logic_uScriptAct_GetRigidbodyVelocity_Target_3, out logic_uScriptAct_GetRigidbodyVelocity_Velocity_3, out logic_uScriptAct_GetRigidbodyVelocity_Magnitude_3);
         local_5_System_Single = logic_uScriptAct_GetRigidbodyVelocity_Magnitude_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_3.Out;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Get Rigidbody Velocity.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f8a4856c-cc69-4695-8af2-f5400853e396", "Set Components (Vector3)", Relay_In_7)) return; 
         {
            {
               logic_uScriptAct_SetComponentsVector3_X_7 = local_13_System_Single;
               
            }
            {
            }
            {
               logic_uScriptAct_SetComponentsVector3_Z_7 = local_8_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_7.In(logic_uScriptAct_SetComponentsVector3_X_7, logic_uScriptAct_SetComponentsVector3_Y_7, logic_uScriptAct_SetComponentsVector3_Z_7, out logic_uScriptAct_SetComponentsVector3_OutputVector3_7);
         local_input_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_7;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("880bde95-bdb3-473a-8922-28c69659ad11", "Multiply Vector3 With Float", Relay_In_10)) return; 
         {
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_10 = local_input_UnityEngine_Vector3;
               
            }
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_10 = local_moveSpeed_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_10.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_10, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_10, out logic_uScriptAct_MultiplyVector3WithFloat_Result_10);
         local_Force_to_Add_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_10;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_10.Out;
         
         if ( test_0 == true )
         {
            Relay_AddForce_12();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Multiply Vector3 With Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_AddForce_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("719eba3d-465a-441a-90ab-a2a4344614a4", "UnityEngine.Rigidbody", Relay_AddForce_12)) return; 
         {
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_force_12 = local_Force_to_Add_UnityEngine_Vector3;
               
            }
         }
         {
            UnityEngine.Rigidbody component;
            component = local_PlayerRigidBody_UnityEngine_GameObject.GetComponent<UnityEngine.Rigidbody>();
            if ( null != component )
            {
               component.AddForce(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_force_12);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at UnityEngine.Rigidbody.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_14()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("27ca9414-e115-4cd6-be90-1b32e0b6d4dd", "Log", Relay_In_14)) return; 
         {
            {
            }
            {
               List<System.Object> properties = new List<System.Object>();
               properties.Add((System.Object)local_input_UnityEngine_Vector3);
               logic_uScriptAct_Log_Target_14 = properties.ToArray();
            }
            {
            }
         }
         logic_uScriptAct_Log_uScriptAct_Log_14.In(logic_uScriptAct_Log_Prefix_14, logic_uScriptAct_Log_Target_14, logic_uScriptAct_Log_Postfix_14);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Log.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:maxSpeed", local_maxSpeed_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "36dd5090-8011-4bb7-a361-1dd1968c69f0", local_maxSpeed_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:PlayerRigidBody", local_PlayerRigidBody_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "66b7efc1-ae37-4259-bfb9-f168b29f0166", local_PlayerRigidBody_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:5", local_5_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "da620670-8c6f-4223-9730-c1183db5297b", local_5_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:moveSpeed", local_moveSpeed_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "849dbcdf-bad9-4699-822a-58421855ae71", local_moveSpeed_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:8", local_8_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ffe62319-76dc-45b7-8aa4-50e6df3c57c9", local_8_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:input", local_input_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "62d18e98-e05c-4c12-8eed-2aafa5c5a4d1", local_input_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:Force to Add", local_Force_to_Add_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a925f7a7-d550-42ce-899a-3eba3e748ea9", local_Force_to_Add_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:13", local_13_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a44fda28-0e89-4b79-8fef-3bcd00a3f545", local_13_System_Single);
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
