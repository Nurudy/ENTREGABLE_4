using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using System;

public class EventsGameManager : MonoBehaviour
{
    public delegate void ReturnClick();
    public static event ReturnClick OnEnterClickPressed;

    public delegate void EscapeClick();
    public static event EscapeClick OnEscapeClickPressed;
    
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Click!");

            if (OnEnterClickPressed != null) OnEnterClickPressed();
        } else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESCAPE");
            if (OnEscapeClickPressed != null) OnEscapeClickPressed();
        }
          
    }
}
