using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class clickButton : EventTrigger
{
    public void EventTrigger()
    {

        // Applica;on.LoadLevel("Scene2-Menu"); // Obsolète depuis la version 4...
        SceneManager.LoadScene("SampleScene");


    }
    
}

