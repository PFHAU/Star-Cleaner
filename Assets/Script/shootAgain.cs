using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAgain : MonoBehaviour
{
    private Vector2 siz;
    bool sp;
   

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        sp = Input.GetKeyDown(KeyCode.Space);
        if(sp)
        {
            shoot();

        }

    }

    public void shoot()
    {
        Vector3 tmpPos = new Vector3(transform.position.x + siz.x, transform.position.y, transform.position.z);
        GameObject gy = Instantiate(Resources.Load("shootOrange"), tmpPos, Quaternion.identity) as GameObject;
        soundState.Instance.TouchButtonSound();
    }
}
