// uScript Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[NodePath("Actions/Variables/3D Lists/Float")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Iterate through each Float in a 3D List (uScript events must drive each iteration)")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("For Each In 3D List (Float)", "Iterates through a 2 Dimensional List, one item at a time, and returns the current item. \n\nNote: uScript events must drive each iteration.")]
public class hyenApp_ForEach3DListFloat : uScriptLogic {

	private float[,,] m_List = null;
	private int m_CurrentIndex = 0;
	private bool m_Done = false;
	private bool m_ImmediateDone = false;

	public bool Immediate {
		get { 
			if (!m_ImmediateDone) {
				m_ImmediateDone = true;
				return true; 
			}
			return false;
		} 
	}

	[FriendlyName("Done Iterating")]
	public bool Done { get { return m_Done; } }

	[FriendlyName("Iteration")]
	public bool Iteration { get { return m_List != null && m_CurrentIndex <= m_List.GetLength(0) * m_List.GetLength(1) * m_List.GetLength(2) && m_CurrentIndex != 0; } }

	[FriendlyName("Reset")]
	public void Reset(float[,,] List, out float Value, out int firstIndex, out int secondIndex, out int thirdIndex) {
		Value = 0;
		m_List = List;

		m_CurrentIndex = 0;
		firstIndex = 0;
		secondIndex = 0;
		thirdIndex = 0;
		m_Done = false;

		m_ImmediateDone = false;
	}

	public void In(
		[FriendlyName("3D List", "The 3D List to iterate over.")] float[,,] List,
		[FriendlyName("Current", "The item for the current loop iteration.")] out float Value,
		[FriendlyName("First Index", "The first index value for the current loop iteration."), SocketState(false, false)] out int firstIndex,
		[FriendlyName("Second Index", "The second index value for the current loop iteration."), SocketState(false, false)] out int secondIndex,
		[FriendlyName("Third Index", "The third index value for the current loop iteration."), SocketState(false, false)] out int thirdIndex
	) {
		if (m_List == null) {
			m_List = List;
			m_CurrentIndex = 0;
			m_Done = false;
		}

		m_ImmediateDone = !(m_List != null && m_CurrentIndex == 0);
		Value = 0;
		firstIndex = 0;		// x
		secondIndex = 0;	// y
		thirdIndex = 0;		// z
		
		if (m_List != null) {
			if (m_CurrentIndex < m_List.GetLength(0) * m_List.GetLength(1) * m_List.GetLength(2)) {
				// split into first second and third indexs
				//firstIndex = m_CurrentIndex % m_List.GetLength(0);
				//secondIndex = m_CurrentIndex / m_List.GetLength(1);
				
				int zQuotient = Math.DivRem(m_CurrentIndex, m_List.GetLength(2), out thirdIndex);
				int yQuotient = Math.DivRem(zQuotient, m_List.GetLength(1), out secondIndex);
				firstIndex = yQuotient % m_List.GetLength(0);
				
				// debug
				//uScriptDebug.Log(m_CurrentIndex +" ["+ firstIndex +", "+ secondIndex +", "+ thirdIndex +"]", uScriptDebug.Type.Warning);
				
				Value = m_List[firstIndex, secondIndex, thirdIndex];
			}
			
			m_CurrentIndex++;
			if (m_CurrentIndex > m_List.GetLength(0) * m_List.GetLength(1) * m_List.GetLength(2)) {
				m_List = null;
				m_Done = true;
			}
			
		}
		
	}
	
}
