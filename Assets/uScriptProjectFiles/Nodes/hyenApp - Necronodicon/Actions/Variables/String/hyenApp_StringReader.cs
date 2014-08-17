// hyenApp Action Node
// (C) 2012 hyenApp LLC

using UnityEngine;
using System;
using System.IO;
using System.Collections;

[NodePath("Actions/Variables/String")]

[NodeCopyright("Copyright 2012 by hyenApp LLC")]
[NodeToolTip("Reads lines from the specified string.")]
[NodeAuthor("hyenApp LLC", "http://www.hyenapp.com")]
[NodeHelp("")]

[FriendlyName("String Reader", "Reads lines from the specified string.")]
public class hyenApp_StringReader : uScriptLogic {

	private StringReader m_Reader = null;
	private string m_Line = null;
	private bool m_Done = false;
	private bool m_ImmediateDone = false;

	// Output Sockets
	public bool Immediate {
		get { 
			if (!m_ImmediateDone) {
				m_ImmediateDone = true;
				return true; 
			}
			return false;
		} 
	}

	[FriendlyName("Done Reading")]
	public bool Done { get { return m_Done; } }

	[FriendlyName("Read Line")]
	public bool ReadLine { get { return m_Line != null; } }

	// Input Sockets and Node Parameters
	[FriendlyName("Reset")]
	public void Reset(string inString, out string Line) {
		Line = null;
		if (m_Reader != null) {
			m_Reader.Close();
		}
		m_Reader = null;
		m_Line = null;
		m_Done = false;
		m_ImmediateDone = false;
	}

	public void In(
		[FriendlyName("String", "The string to read lines from.")] string inString,
		[FriendlyName("Line", "The current line read from the specified string.")] out string Line
	) {
		if (m_Reader == null) {
			m_Reader = new StringReader(inString);
			m_Done = false;
		}
		
		m_ImmediateDone = !(m_Reader != null && m_Line == null);
		
		if ( (m_Line = m_Reader.ReadLine()) == null ) {
			m_Done = true;
			m_Reader.Close();
		}
		Line = m_Line;
	}

}
