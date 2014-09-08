//uScript Generated Code - Build 1.0.2594
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Player Move", "Player Movement - Restricted to cardinal directions. Most recent direction takes control.")]
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
   System.Single local_2_System_Single = (float) 0;
   System.String local_23_System_String = "East";
   System.String local_24_System_String = "West";
   System.String local_25_System_String = "North";
   System.String local_26_System_String = "South";
   System.Single local_31_System_Single = (float) 0;
   System.Single local_32_System_Single = (float) 0;
   System.Single local_34_System_Single = (float) 0;
   System.Single local_36_System_Single = (float) 0;
   System.Single local_41_System_Single = (float) 0;
   System.Single local_42_System_Single = (float) 0;
   System.String local_45_System_String = "West";
   System.String local_47_System_String = "South";
   System.String local_50_System_String = "North";
   System.String local_52_System_String = "East";
   System.Single local_Abs_X_System_Single = (float) 0;
   System.Single local_Abs_Z_System_Single = (float) 0;
   System.String local_Facing_System_String = "North";
   System.Single local_Horizontal_X_System_Single = (float) 0;
   System.Single local_Speed_System_Single = (float) 5;
   System.String local_This_Direction_System_String = "";
   System.Single local_Vertical_Z_System_Single = (float) 0;
   public System.Single Threshold = (float) 0.5;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_13 = null;
   UnityEngine.GameObject owner_Connection_27 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetRigidbodyVelocity logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_1 = new uScriptAct_GetRigidbodyVelocity( );
   UnityEngine.GameObject logic_uScriptAct_GetRigidbodyVelocity_Target_1 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_GetRigidbodyVelocity_Velocity_1;
   System.Single logic_uScriptAct_GetRigidbodyVelocity_Magnitude_1;
   bool logic_uScriptAct_GetRigidbodyVelocity_Out_1 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_5 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_5 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_5 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_5 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_5 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_5 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_5 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_5 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_5 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_10 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_10 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_10 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_10 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_11 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_11 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_11 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_11 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_11 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_11 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_11 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_11 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_11 = true;
   //pointer to script instanced logic node
   uScriptCon_StringSwitch logic_uScriptCon_StringSwitch_uScriptCon_StringSwitch_15 = new uScriptCon_StringSwitch( );
   System.String[] logic_uScriptCon_StringSwitch_Targets_15 = new System.String[] {};
   System.String logic_uScriptCon_StringSwitch_A_15 = "North";
   System.String logic_uScriptCon_StringSwitch_B_15 = "South";
   System.String logic_uScriptCon_StringSwitch_C_15 = "East";
   System.String logic_uScriptCon_StringSwitch_D_15 = "West";
   bool logic_uScriptCon_StringSwitch_None_15 = true;
   bool logic_uScriptCon_StringSwitch_Any_15 = true;
   bool logic_uScriptCon_StringSwitch_All_15 = true;
   bool logic_uScriptCon_StringSwitch_AMatch_15 = true;
   bool logic_uScriptCon_StringSwitch_BMatch_15 = true;
   bool logic_uScriptCon_StringSwitch_CMatch_15 = true;
   bool logic_uScriptCon_StringSwitch_DMatch_15 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_17 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_17 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_17 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_17 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_17 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_17 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_17 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_17 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_17 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_18 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_18 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_18 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_18 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_18 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_18 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_18 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_18 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_18 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_19 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_19 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_19 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_19 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_19 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_19;
   bool logic_uScriptAct_SetString_Out_19 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_20 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_20 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_20 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_20 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_20 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_20;
   bool logic_uScriptAct_SetString_Out_20 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_21 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_21 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_21 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_21 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_21 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_21;
   bool logic_uScriptAct_SetString_Out_21 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_22 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_22 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_22 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_22 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_22 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_22;
   bool logic_uScriptAct_SetString_Out_22 = true;
   //pointer to script instanced logic node
   uScriptAct_GetDeltaTime logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_28 = new uScriptAct_GetDeltaTime( );
   System.Single logic_uScriptAct_GetDeltaTime_DeltaTime_28;
   System.Single logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_28;
   System.Single logic_uScriptAct_GetDeltaTime_FixedDeltaTime_28;
   bool logic_uScriptAct_GetDeltaTime_Out_28 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_29 = new uScriptAct_MultiplyFloat( );
   System.Single[] logic_uScriptAct_MultiplyFloat_A_29 = new System.Single[] {};
   System.Single[] logic_uScriptAct_MultiplyFloat_B_29 = new System.Single[] {};
   System.Single logic_uScriptAct_MultiplyFloat_FloatResult_29;
   System.Int32 logic_uScriptAct_MultiplyFloat_IntResult_29;
   bool logic_uScriptAct_MultiplyFloat_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_30 = new uScriptAct_MultiplyFloat( );
   System.Single[] logic_uScriptAct_MultiplyFloat_A_30 = new System.Single[] {};
   System.Single[] logic_uScriptAct_MultiplyFloat_B_30 = new System.Single[] {};
   System.Single logic_uScriptAct_MultiplyFloat_FloatResult_30;
   System.Int32 logic_uScriptAct_MultiplyFloat_IntResult_30;
   bool logic_uScriptAct_MultiplyFloat_Out_30 = true;
   //pointer to script instanced logic node
   uScriptAct_GetDeltaTime logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_35 = new uScriptAct_GetDeltaTime( );
   System.Single logic_uScriptAct_GetDeltaTime_DeltaTime_35;
   System.Single logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_35;
   System.Single logic_uScriptAct_GetDeltaTime_FixedDeltaTime_35;
   bool logic_uScriptAct_GetDeltaTime_Out_35 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_37 = new uScriptAct_MultiplyFloat( );
   System.Single[] logic_uScriptAct_MultiplyFloat_A_37 = new System.Single[] {};
   System.Single[] logic_uScriptAct_MultiplyFloat_B_37 = new System.Single[] {};
   System.Single logic_uScriptAct_MultiplyFloat_FloatResult_37;
   System.Int32 logic_uScriptAct_MultiplyFloat_IntResult_37;
   bool logic_uScriptAct_MultiplyFloat_Out_37 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_38 = new uScriptAct_MultiplyFloat( );
   System.Single[] logic_uScriptAct_MultiplyFloat_A_38 = new System.Single[] {};
   System.Single[] logic_uScriptAct_MultiplyFloat_B_38 = new System.Single[] {};
   System.Single logic_uScriptAct_MultiplyFloat_FloatResult_38;
   System.Int32 logic_uScriptAct_MultiplyFloat_IntResult_38;
   bool logic_uScriptAct_MultiplyFloat_Out_38 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_43 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_43 = "";
   System.Object[] logic_uScriptAct_Log_Target_43 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_43 = "";
   bool logic_uScriptAct_Log_Out_43 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_44 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_44 = "";
   System.Object[] logic_uScriptAct_Log_Target_44 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_44 = "";
   bool logic_uScriptAct_Log_Out_44 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_46 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_46 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_46 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_46 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_46 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_46 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_46 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_46 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_46 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_48 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_48 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_48 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_48 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_48 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_48;
   bool logic_uScriptAct_SetString_Out_48 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_49 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_49 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_49 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_49 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_49 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_49;
   bool logic_uScriptAct_SetString_Out_49 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_51 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_51 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_51 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_51 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_51 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_51 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_51 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_51 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_51 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_53 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_53 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_53 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_53 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_53 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_53;
   bool logic_uScriptAct_SetString_Out_53 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_54 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_54 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_54 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_54 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_54 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_54;
   bool logic_uScriptAct_SetString_Out_54 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_56 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_56 = "";
   System.Object[] logic_uScriptAct_Log_Target_56 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_56 = "";
   bool logic_uScriptAct_Log_Out_56 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_57 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_57 = "";
   System.String logic_uScriptCon_CompareString_B_57 = "South";
   bool logic_uScriptCon_CompareString_Same_57 = true;
   bool logic_uScriptCon_CompareString_Different_57 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_58 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_58 = "";
   System.String logic_uScriptCon_CompareString_B_58 = "East";
   bool logic_uScriptCon_CompareString_Same_58 = true;
   bool logic_uScriptCon_CompareString_Different_58 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_59 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_59 = "";
   System.String logic_uScriptCon_CompareString_B_59 = "North";
   bool logic_uScriptCon_CompareString_Same_59 = true;
   bool logic_uScriptCon_CompareString_Different_59 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_60 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_60 = "";
   System.String logic_uScriptCon_CompareString_B_60 = "West";
   bool logic_uScriptCon_CompareString_Same_60 = true;
   bool logic_uScriptCon_CompareString_Different_60 = true;
   
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
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_6 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_6 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_7 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_7 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_33 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_33 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_33 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_39 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_39 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_39 = (float) 0;
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_13 || false == m_RegisteredForEvents )
      {
         owner_Connection_13 = parentGameObject;
      }
      if ( null == owner_Connection_27 || false == m_RegisteredForEvents )
      {
         owner_Connection_27 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
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
      
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_1.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_5.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_11.SetParent(g);
      logic_uScriptCon_StringSwitch_uScriptCon_StringSwitch_15.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_17.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_18.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_19.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_20.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_21.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_22.SetParent(g);
      logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_28.SetParent(g);
      logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_29.SetParent(g);
      logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_30.SetParent(g);
      logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_35.SetParent(g);
      logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_37.SetParent(g);
      logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_38.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_43.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_44.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_46.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_48.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_49.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_51.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_53.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_54.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_56.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_57.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_58.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_59.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_60.SetParent(g);
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
      local_Horizontal_X_System_Single = event_UnityEngine_GameObject_Horizontal_0;
      local_Vertical_Z_System_Single = event_UnityEngine_GameObject_Vertical_0;
      Relay_In_46();
      Relay_In_51();
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ed5b9bf8-d5b9-4c68-9708-3a1fd804009a", "Get Rigidbody Velocity", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_GetRigidbodyVelocity_Target_1 = owner_Connection_13;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_1.In(logic_uScriptAct_GetRigidbodyVelocity_Target_1, out logic_uScriptAct_GetRigidbodyVelocity_Velocity_1, out logic_uScriptAct_GetRigidbodyVelocity_Magnitude_1);
         local_2_System_Single = logic_uScriptAct_GetRigidbodyVelocity_Magnitude_1;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_1.Out;
         
         if ( test_0 == true )
         {
            Relay_Abs_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Get Rigidbody Velocity.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3f8b7a00-4d4b-48b7-a7d7-fcea0321c07f", "Compare Float", Relay_In_5)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_5 = local_Abs_X_System_Single;
               
            }
            {
               logic_uScriptCon_CompareFloat_B_5 = local_Abs_Z_System_Single;
               
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_5.In(logic_uScriptCon_CompareFloat_A_5, logic_uScriptCon_CompareFloat_B_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_5.GreaterThan;
         bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_5.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
         if ( test_1 == true )
         {
            Relay_In_11();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Abs_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("38af5395-2d4d-4731-860c-d5f644f5820e", "System.Math", Relay_Abs_6)) return; 
         {
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_6 = local_Horizontal_X_System_Single;
               
            }
            {
            }
         }
         method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_6 = System.Math.Abs(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_6);
         local_Abs_X_System_Single = method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_6;
         Relay_In_5();
         Relay_In_44();
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at System.Math.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Abs_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d4bf35be-43df-4b8b-a772-0fd72461c6ea", "System.Math", Relay_Abs_7)) return; 
         {
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_7 = local_Vertical_Z_System_Single;
               
            }
            {
            }
         }
         method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_7 = System.Math.Abs(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_7);
         local_Abs_Z_System_Single = method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_7;
         Relay_Abs_6();
         Relay_In_43();
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at System.Math.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("edd93fca-0472-4cc5-aa7e-6f4370646b0d", "Compare Float", Relay_In_10)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_10 = local_Abs_X_System_Single;
               
            }
            {
               logic_uScriptCon_CompareFloat_B_10 = Threshold;
               
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.In(logic_uScriptCon_CompareFloat_A_10, logic_uScriptCon_CompareFloat_B_10);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_10.GreaterThanOrEqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("86643ce5-2fe1-42ba-97ba-abddb3d2b8f0", "Compare Float", Relay_In_11)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_11 = local_Abs_Z_System_Single;
               
            }
            {
               logic_uScriptCon_CompareFloat_B_11 = Threshold;
               
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_11.In(logic_uScriptCon_CompareFloat_A_11, logic_uScriptCon_CompareFloat_B_11);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_11.GreaterThanOrEqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_18();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d0041e96-636a-4a41-b8ba-4b538edeaf85", "String Switch", Relay_In_15)) return; 
         {
            {
               List<System.String> properties = new List<System.String>();
               properties.Add((System.String)local_This_Direction_System_String);
               logic_uScriptCon_StringSwitch_Targets_15 = properties.ToArray();
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
         logic_uScriptCon_StringSwitch_uScriptCon_StringSwitch_15.In(logic_uScriptCon_StringSwitch_Targets_15, logic_uScriptCon_StringSwitch_A_15, logic_uScriptCon_StringSwitch_B_15, logic_uScriptCon_StringSwitch_C_15, logic_uScriptCon_StringSwitch_D_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_StringSwitch_uScriptCon_StringSwitch_15.AMatch;
         bool test_1 = logic_uScriptCon_StringSwitch_uScriptCon_StringSwitch_15.BMatch;
         bool test_2 = logic_uScriptCon_StringSwitch_uScriptCon_StringSwitch_15.CMatch;
         bool test_3 = logic_uScriptCon_StringSwitch_uScriptCon_StringSwitch_15.DMatch;
         
         if ( test_0 == true )
         {
            Relay_In_57();
         }
         if ( test_1 == true )
         {
            Relay_In_59();
         }
         if ( test_2 == true )
         {
            Relay_In_60();
         }
         if ( test_3 == true )
         {
            Relay_In_58();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at String Switch.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f047f851-36a0-4cfd-ac97-fea743d49036", "Compare Float", Relay_In_17)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_17 = local_Horizontal_X_System_Single;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_17.In(logic_uScriptCon_CompareFloat_A_17, logic_uScriptCon_CompareFloat_B_17);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_17.GreaterThan;
         bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_17.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_20();
         }
         if ( test_1 == true )
         {
            Relay_In_22();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e2966af9-339b-40c9-87a4-55e6759e0972", "Compare Float", Relay_In_18)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_18 = local_Vertical_Z_System_Single;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_18.In(logic_uScriptCon_CompareFloat_A_18, logic_uScriptCon_CompareFloat_B_18);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_18.GreaterThan;
         bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_18.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_19();
         }
         if ( test_1 == true )
         {
            Relay_In_21();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_19()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("30e130d8-47c9-41fc-8995-3a81e463d2f1", "Set String", Relay_In_19)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_19 = local_25_System_String;
               
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
         logic_uScriptAct_SetString_uScriptAct_SetString_19.In(logic_uScriptAct_SetString_Value_19, logic_uScriptAct_SetString_ToUpperCase_19, logic_uScriptAct_SetString_ToLowerCase_19, logic_uScriptAct_SetString_TrimWhitespace_19, out logic_uScriptAct_SetString_Target_19);
         local_Facing_System_String = logic_uScriptAct_SetString_Target_19;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_19.Out;
         
         if ( test_0 == true )
         {
            Relay_In_35();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("cfba595b-2dab-4b9f-b80d-9240a89ea592", "Set String", Relay_In_20)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_20 = local_23_System_String;
               
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
         logic_uScriptAct_SetString_uScriptAct_SetString_20.In(logic_uScriptAct_SetString_Value_20, logic_uScriptAct_SetString_ToUpperCase_20, logic_uScriptAct_SetString_ToLowerCase_20, logic_uScriptAct_SetString_TrimWhitespace_20, out logic_uScriptAct_SetString_Target_20);
         local_Facing_System_String = logic_uScriptAct_SetString_Target_20;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_20.Out;
         
         if ( test_0 == true )
         {
            Relay_In_28();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fba12eae-71ff-4641-b0a0-3122d90a4145", "Set String", Relay_In_21)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_21 = local_26_System_String;
               
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
         logic_uScriptAct_SetString_uScriptAct_SetString_21.In(logic_uScriptAct_SetString_Value_21, logic_uScriptAct_SetString_ToUpperCase_21, logic_uScriptAct_SetString_ToLowerCase_21, logic_uScriptAct_SetString_TrimWhitespace_21, out logic_uScriptAct_SetString_Target_21);
         local_Facing_System_String = logic_uScriptAct_SetString_Target_21;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_21.Out;
         
         if ( test_0 == true )
         {
            Relay_In_35();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_22()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("512411bb-6e52-4e73-9b4d-47e5bcacba5f", "Set String", Relay_In_22)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_22 = local_24_System_String;
               
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
         logic_uScriptAct_SetString_uScriptAct_SetString_22.In(logic_uScriptAct_SetString_Value_22, logic_uScriptAct_SetString_ToUpperCase_22, logic_uScriptAct_SetString_ToLowerCase_22, logic_uScriptAct_SetString_TrimWhitespace_22, out logic_uScriptAct_SetString_Target_22);
         local_Facing_System_String = logic_uScriptAct_SetString_Target_22;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_22.Out;
         
         if ( test_0 == true )
         {
            Relay_In_28();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_28()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5918de38-74b7-4e10-b57f-8bf35c688b16", "Get Delta Time", Relay_In_28)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_28.In(out logic_uScriptAct_GetDeltaTime_DeltaTime_28, out logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_28, out logic_uScriptAct_GetDeltaTime_FixedDeltaTime_28);
         local_31_System_Single = logic_uScriptAct_GetDeltaTime_DeltaTime_28;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_28.Out;
         
         if ( test_0 == true )
         {
            Relay_In_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Get Delta Time.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("faa1ac0c-9495-4bcc-aa10-084d26b14982", "Multiply Float", Relay_In_29)) return; 
         {
            {
               List<System.Single> properties = new List<System.Single>();
               properties.Add((System.Single)local_Horizontal_X_System_Single);
               logic_uScriptAct_MultiplyFloat_A_29 = properties.ToArray();
            }
            {
               List<System.Single> properties = new List<System.Single>();
               properties.Add((System.Single)local_31_System_Single);
               logic_uScriptAct_MultiplyFloat_B_29 = properties.ToArray();
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_29.In(logic_uScriptAct_MultiplyFloat_A_29, logic_uScriptAct_MultiplyFloat_B_29, out logic_uScriptAct_MultiplyFloat_FloatResult_29, out logic_uScriptAct_MultiplyFloat_IntResult_29);
         local_32_System_Single = logic_uScriptAct_MultiplyFloat_FloatResult_29;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_29.Out;
         
         if ( test_0 == true )
         {
            Relay_In_30();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_30()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3ec3ea5d-a4cc-4977-94d1-5be79a12facd", "Multiply Float", Relay_In_30)) return; 
         {
            {
               List<System.Single> properties = new List<System.Single>();
               properties.Add((System.Single)local_32_System_Single);
               logic_uScriptAct_MultiplyFloat_A_30 = properties.ToArray();
            }
            {
               List<System.Single> properties = new List<System.Single>();
               properties.Add((System.Single)local_Speed_System_Single);
               logic_uScriptAct_MultiplyFloat_B_30 = properties.ToArray();
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_30.In(logic_uScriptAct_MultiplyFloat_A_30, logic_uScriptAct_MultiplyFloat_B_30, out logic_uScriptAct_MultiplyFloat_FloatResult_30, out logic_uScriptAct_MultiplyFloat_IntResult_30);
         local_34_System_Single = logic_uScriptAct_MultiplyFloat_FloatResult_30;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_30.Out;
         
         if ( test_0 == true )
         {
            Relay_Translate_33();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_33()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("cf905187-bf6d-4642-9bea-bbe0236222d1", "UnityEngine.Transform", Relay_Translate_33)) return; 
         {
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_33 = local_34_System_Single;
               
            }
            {
            }
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_27.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_33, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_33, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_33);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_35()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1e754d38-700b-4776-8d5f-7dca13b184b7", "Get Delta Time", Relay_In_35)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_35.In(out logic_uScriptAct_GetDeltaTime_DeltaTime_35, out logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_35, out logic_uScriptAct_GetDeltaTime_FixedDeltaTime_35);
         local_42_System_Single = logic_uScriptAct_GetDeltaTime_DeltaTime_35;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_35.Out;
         
         if ( test_0 == true )
         {
            Relay_In_37();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Get Delta Time.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_37()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("86695ea6-7f17-4e7c-93da-74aedec042c2", "Multiply Float", Relay_In_37)) return; 
         {
            {
               List<System.Single> properties = new List<System.Single>();
               properties.Add((System.Single)local_Vertical_Z_System_Single);
               logic_uScriptAct_MultiplyFloat_A_37 = properties.ToArray();
            }
            {
               List<System.Single> properties = new List<System.Single>();
               properties.Add((System.Single)local_42_System_Single);
               logic_uScriptAct_MultiplyFloat_B_37 = properties.ToArray();
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_37.In(logic_uScriptAct_MultiplyFloat_A_37, logic_uScriptAct_MultiplyFloat_B_37, out logic_uScriptAct_MultiplyFloat_FloatResult_37, out logic_uScriptAct_MultiplyFloat_IntResult_37);
         local_41_System_Single = logic_uScriptAct_MultiplyFloat_FloatResult_37;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_37.Out;
         
         if ( test_0 == true )
         {
            Relay_In_38();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_38()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d5593a5f-c886-413c-bfe5-69294a903826", "Multiply Float", Relay_In_38)) return; 
         {
            {
               List<System.Single> properties = new List<System.Single>();
               properties.Add((System.Single)local_41_System_Single);
               logic_uScriptAct_MultiplyFloat_A_38 = properties.ToArray();
            }
            {
               List<System.Single> properties = new List<System.Single>();
               properties.Add((System.Single)local_Speed_System_Single);
               logic_uScriptAct_MultiplyFloat_B_38 = properties.ToArray();
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_38.In(logic_uScriptAct_MultiplyFloat_A_38, logic_uScriptAct_MultiplyFloat_B_38, out logic_uScriptAct_MultiplyFloat_FloatResult_38, out logic_uScriptAct_MultiplyFloat_IntResult_38);
         local_36_System_Single = logic_uScriptAct_MultiplyFloat_FloatResult_38;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_uScriptAct_MultiplyFloat_38.Out;
         
         if ( test_0 == true )
         {
            Relay_Translate_39();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_39()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("06f1ab2d-df89-4af7-84c8-c22cf9f7567b", "UnityEngine.Transform", Relay_Translate_39)) return; 
         {
            {
            }
            {
            }
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_39 = local_36_System_Single;
               
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_27.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_39, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_39, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_39);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_43()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2c4f1b00-f409-4a8b-98d5-98a80d617c37", "Log", Relay_In_43)) return; 
         {
            {
            }
            {
               List<System.Object> properties = new List<System.Object>();
               properties.Add((System.Object)local_Abs_Z_System_Single);
               logic_uScriptAct_Log_Target_43 = properties.ToArray();
            }
            {
            }
         }
         logic_uScriptAct_Log_uScriptAct_Log_43.In(logic_uScriptAct_Log_Prefix_43, logic_uScriptAct_Log_Target_43, logic_uScriptAct_Log_Postfix_43);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_43.Out;
         
         if ( test_0 == true )
         {
            Relay_Abs_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Log.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_44()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b3240220-5354-4e17-acc6-0c52f379d363", "Log", Relay_In_44)) return; 
         {
            {
            }
            {
               List<System.Object> properties = new List<System.Object>();
               properties.Add((System.Object)local_Abs_X_System_Single);
               logic_uScriptAct_Log_Target_44 = properties.ToArray();
            }
            {
            }
         }
         logic_uScriptAct_Log_uScriptAct_Log_44.In(logic_uScriptAct_Log_Prefix_44, logic_uScriptAct_Log_Target_44, logic_uScriptAct_Log_Postfix_44);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_44.Out;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Log.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_46()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7d59f81f-3178-48f0-ac66-9d7c6303540a", "Compare Float", Relay_In_46)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_46 = local_Horizontal_X_System_Single;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_46.In(logic_uScriptCon_CompareFloat_A_46, logic_uScriptCon_CompareFloat_B_46);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_46.GreaterThan;
         bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_46.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_48();
         }
         if ( test_1 == true )
         {
            Relay_In_53();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_48()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7530efac-9c8b-414e-af8f-4e795bfbfb95", "Set String", Relay_In_48)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_48 = local_52_System_String;
               
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
         logic_uScriptAct_SetString_uScriptAct_SetString_48.In(logic_uScriptAct_SetString_Value_48, logic_uScriptAct_SetString_ToUpperCase_48, logic_uScriptAct_SetString_ToLowerCase_48, logic_uScriptAct_SetString_TrimWhitespace_48, out logic_uScriptAct_SetString_Target_48);
         local_This_Direction_System_String = logic_uScriptAct_SetString_Target_48;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_48.Out;
         
         if ( test_0 == true )
         {
            Relay_In_15();
            Relay_In_56();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_49()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8448bbb5-134a-4782-bf58-4162aab80a97", "Set String", Relay_In_49)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_49 = local_50_System_String;
               
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
         logic_uScriptAct_SetString_uScriptAct_SetString_49.In(logic_uScriptAct_SetString_Value_49, logic_uScriptAct_SetString_ToUpperCase_49, logic_uScriptAct_SetString_ToLowerCase_49, logic_uScriptAct_SetString_TrimWhitespace_49, out logic_uScriptAct_SetString_Target_49);
         local_This_Direction_System_String = logic_uScriptAct_SetString_Target_49;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_49.Out;
         
         if ( test_0 == true )
         {
            Relay_In_15();
            Relay_In_56();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_51()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2ce13f5e-87fe-4a19-bd92-6d529333dfa0", "Compare Float", Relay_In_51)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_51 = local_Vertical_Z_System_Single;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_51.In(logic_uScriptCon_CompareFloat_A_51, logic_uScriptCon_CompareFloat_B_51);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_51.GreaterThan;
         bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_51.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_49();
         }
         if ( test_1 == true )
         {
            Relay_In_54();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_53()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e750a9c4-dd99-4240-ac87-772da4374d38", "Set String", Relay_In_53)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_53 = local_45_System_String;
               
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
         logic_uScriptAct_SetString_uScriptAct_SetString_53.In(logic_uScriptAct_SetString_Value_53, logic_uScriptAct_SetString_ToUpperCase_53, logic_uScriptAct_SetString_ToLowerCase_53, logic_uScriptAct_SetString_TrimWhitespace_53, out logic_uScriptAct_SetString_Target_53);
         local_This_Direction_System_String = logic_uScriptAct_SetString_Target_53;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_53.Out;
         
         if ( test_0 == true )
         {
            Relay_In_15();
            Relay_In_56();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_54()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8cd60acd-dc43-46b3-9f92-bd5bd4b622d3", "Set String", Relay_In_54)) return; 
         {
            {
               logic_uScriptAct_SetString_Value_54 = local_47_System_String;
               
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
         logic_uScriptAct_SetString_uScriptAct_SetString_54.In(logic_uScriptAct_SetString_Value_54, logic_uScriptAct_SetString_ToUpperCase_54, logic_uScriptAct_SetString_ToLowerCase_54, logic_uScriptAct_SetString_TrimWhitespace_54, out logic_uScriptAct_SetString_Target_54);
         local_This_Direction_System_String = logic_uScriptAct_SetString_Target_54;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_54.Out;
         
         if ( test_0 == true )
         {
            Relay_In_15();
            Relay_In_56();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Set String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_56()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f70b5503-5f7a-41b1-bba0-850cb26553d0", "Log", Relay_In_56)) return; 
         {
            {
            }
            {
               List<System.Object> properties = new List<System.Object>();
               properties.Add((System.Object)local_This_Direction_System_String);
               logic_uScriptAct_Log_Target_56 = properties.ToArray();
            }
            {
            }
         }
         logic_uScriptAct_Log_uScriptAct_Log_56.In(logic_uScriptAct_Log_Prefix_56, logic_uScriptAct_Log_Target_56, logic_uScriptAct_Log_Postfix_56);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Log.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_57()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5285914e-89cb-4860-8c40-895316155e37", "Compare String", Relay_In_57)) return; 
         {
            {
               logic_uScriptCon_CompareString_A_57 = local_Facing_System_String;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareString_uScriptCon_CompareString_57.In(logic_uScriptCon_CompareString_A_57, logic_uScriptCon_CompareString_B_57);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_57.Different;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_58()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2218d533-818c-4144-9345-32b90b6ce7f2", "Compare String", Relay_In_58)) return; 
         {
            {
               logic_uScriptCon_CompareString_A_58 = local_Facing_System_String;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareString_uScriptCon_CompareString_58.In(logic_uScriptCon_CompareString_A_58, logic_uScriptCon_CompareString_B_58);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_58.Different;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_59()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("6a68650f-da71-4fe5-9c22-84122b798b08", "Compare String", Relay_In_59)) return; 
         {
            {
               logic_uScriptCon_CompareString_A_59 = local_Facing_System_String;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareString_uScriptCon_CompareString_59.In(logic_uScriptCon_CompareString_A_59, logic_uScriptCon_CompareString_B_59);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_59.Different;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_60()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("27186abe-f779-4c9f-8a37-ac123d196089", "Compare String", Relay_In_60)) return; 
         {
            {
               logic_uScriptCon_CompareString_A_60 = local_Facing_System_String;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareString_uScriptCon_CompareString_60.In(logic_uScriptCon_CompareString_A_60, logic_uScriptCon_CompareString_B_60);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_60.Different;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript PlayerMove.uscript at Compare String.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:2", local_2_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "da620670-8c6f-4223-9730-c1183db5297b", local_2_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:Vertical Z", local_Vertical_Z_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ffe62319-76dc-45b7-8aa4-50e6df3c57c9", local_Vertical_Z_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:Horizontal X", local_Horizontal_X_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a44fda28-0e89-4b79-8fef-3bcd00a3f545", local_Horizontal_X_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:Abs Z", local_Abs_Z_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a753e2cd-7358-41b0-a5e6-ae5815a801ae", local_Abs_Z_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:Abs X", local_Abs_X_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "558a327c-e3d9-4804-8168-4b13755e6ac8", local_Abs_X_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:Threshold", Threshold);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a3d1e354-83f2-47d6-88d9-7e954882bd68", Threshold);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:Facing", local_Facing_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b7057f08-1f87-47f8-a34b-71003143035a", local_Facing_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:23", local_23_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "d68b2387-869f-4314-9304-060219d08d78", local_23_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:24", local_24_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "94185c36-5032-4b88-96aa-2a5b7a9a919c", local_24_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:25", local_25_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "4785e810-5106-46b3-ad73-5167c8024238", local_25_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:26", local_26_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7afaa052-a910-4aaf-8fa6-7d652b3ccfd2", local_26_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:31", local_31_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3205ec71-9f52-4bd9-838e-45250529d2c5", local_31_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:32", local_32_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "edaacf1f-783b-467a-ba32-afb4b719fa56", local_32_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:34", local_34_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "74b5a4cf-86a8-4bbf-8f0c-d1204db06723", local_34_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:36", local_36_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "dd7d8e4a-027b-4e17-ac18-ab4487b9d29a", local_36_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:Speed", local_Speed_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "19a47f07-dad9-4e5c-8c47-9103442a5db7", local_Speed_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:41", local_41_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "392f1c6e-0059-4073-bf05-66b1413c2f92", local_41_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:42", local_42_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f9174b99-d5f3-4848-9b05-3c262f4e7655", local_42_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:45", local_45_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3ca25c96-3d6e-43e8-871b-271e6010eb5e", local_45_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:47", local_47_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "de521af8-56a8-4781-a0bb-42bc31d380e6", local_47_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:50", local_50_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3cc56630-93f7-478b-a29a-3af1142709f2", local_50_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:52", local_52_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "2f9dd493-fb23-48aa-9ef3-9377ad2a3b64", local_52_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "PlayerMove.uscript:This Direction", local_This_Direction_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "896645af-1386-4e9a-ba5a-30ed5d999b38", local_This_Direction_System_String);
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
