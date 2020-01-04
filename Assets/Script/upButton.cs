using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class upButton : MonoBehaviour
{
    // public void EventTrigger()
    //{
    /* Debug.Log("dgjfsdogj");
     GameObject ur =GameObject.FindWithTag("Player");
     ur.GetComponent<moveShip>().UpVert();*/
    // }
    public GameObject sh;
    public void onPress()
    {
        sh.GetComponent<moveShip>().move(1);
    }

    public void onRelease()
    {
        sh.GetComponent<moveShip>().move(0);

    }

}
