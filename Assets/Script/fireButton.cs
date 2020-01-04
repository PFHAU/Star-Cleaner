using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fireButton : EventTrigger
{
    public void EventTrigger()
    {

        // Applica;on.LoadLevel("Scene2-Menu"); // Obsolète depuis la version 4...
        GameObject.FindWithTag("Player").GetComponent<shootAgain>().shoot();



    }
}
