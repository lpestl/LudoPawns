using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Only for debug using.
/// This is a temporary crutch for testing.
/// </summary>
public class EchoLog : MonoBehaviour {
#region Event log
    public delegate void EventHandlerLog(string msg);
    public static EventHandlerLog OnLog;

    public static void Print(string msg)
    {
        Debug.Log(msg);
        if (OnLog != null)
        {
            OnLog(msg);
        }
    }
#endregion

#region Subscribe on this
    private void OnEnable()
    {
        EchoLog.OnLog += OnPrintLog;
    }

    private void OnDisable()
    {
        EchoLog.OnLog -= OnPrintLog;
    }

    private void OnPrintLog(string msg)
    {
        messages.Add(msg);
    }
#endregion

#region Print log message in old gui
    public int maxCountMessage = 100;
    public List<string> messages;

    void Awake()
    {
        messages = new List<string>();
        // NOTE: Do not worry. This hardcode with magical numbers is temporary and / or disposable. It is only needed for fast debugging.
        //windowRect = new Rect(Screen.width - (float)Screen.width / 4.0f, 10, Screen.width / 4.0f - 10, Screen.height - 20);
        windowRect = new Rect(10, 10, Screen.width - 20, Screen.height / 5);
    }

    private Rect windowRect;
    void OnGUI()
    {
        windowRect = GUI.Window(1, windowRect, GuiConsole, "GUI log");
    }

    private void GuiConsole(int id)
    {
        var strCount = (messages.Count >= maxCountMessage) ? messages.Count.ToString() : maxCountMessage.ToString() + "+";
        GUI.Label(new Rect(25, 15, windowRect.width - 50, 25), "Count = " + strCount);
        int y = 15, deltay = 20;
        for (var i = messages.Count -1; i >0; i--)
        {
            GUI.Label(new Rect(10, y += deltay, windowRect.width - 20, windowRect.height - 30), messages[i]);
        }

        if (messages.Count > maxCountMessage)
        {
            messages.RemoveAt(0);
        }
    }
#endregion
}
