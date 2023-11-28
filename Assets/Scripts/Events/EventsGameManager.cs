using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using System;

public class EventsGameManager : MonoBehaviour
{
    public delegate void ReturnClick();
    public static event ReturnClick OnEnterClickPressed;


    
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Click!");

            if (OnEnterClickPressed != null) OnEnterClickPressed();
        }
          
    }
}
