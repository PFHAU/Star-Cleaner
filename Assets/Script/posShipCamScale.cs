using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //une version du prof
    public Camera mainCamera;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = mainCamera.ViewportToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = transform.position;

    }
}
