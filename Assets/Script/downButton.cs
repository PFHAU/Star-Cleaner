using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downButton : MonoBehaviour
{
    public GameObject sh;
    public void onPress()
    {
        sh.GetComponent<moveShip>().move(-1);
    }

    public void onRelease()
    {
        sh.GetComponent<moveShip>().move(0);

    }
}
