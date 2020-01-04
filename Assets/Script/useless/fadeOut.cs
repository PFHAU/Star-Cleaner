using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Color cl = GetComponent<SpriteRenderer>().color;
        cl.a -= 0.01f;
        GetComponent<SpriteRenderer>().color = cl;
        if (cl.a < 0)
        {
            Destroy(gameObject);
        }
    }
}
