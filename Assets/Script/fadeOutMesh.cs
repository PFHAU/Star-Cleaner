using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOutMesh : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Color cl = GetComponent<TextMesh>().color;
        cl.a -= 0.01f;
        GetComponent<TextMesh>().color = cl;
        if (cl.a < 0)
        {
            Destroy(gameObject);
        }
    }
}
