using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour
{

    public Vector2 speed;
    public static Vector2 movement;
    //private Vector2 movement2;
    public float x;
    public float y;
   // public float xTouch;
  /*  private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;*/

   

    // Update is called once per frame
   /* void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        }
        if (Input.GetMouseButton(0))
        {
            //touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        }
        else
        {
            touchStart = false;
        }

        if (touchStart)
        {
            Vector2 direction = Vector2.ClampMagnitude(pointB - pointA, 1.0f);
            this.transform.Translate(direction * speed * Time.deltaTime);
        }

        y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");*/
        //on peux unifier avec la fonction UpVert
      //  movement = new Vector2(speed.x * x, speed.y * y);
       //movement2 = new Vector2(0, speed.y * yTouch);
      //  GetComponent<Rigidbody2D>().velocity = movement;
        // GetComponent<Rigidbody2D>().velocity = movement2;
        /*if (Input.GetButtonDown("upButton"))
        {
            Debug.Log("RRRRR");
            moove(1);
        }*/
       // yTouch = 0;
   // }

   /* public void UpVert()
    {
        GameObject ship  = GameObject.FindWithTag("Player");
        movement = new Vector2(0, ship.GetComponent<moveShip>().speed.y * 1);
        ship.GetComponent<Rigidbody2D>().velocity = movement;

    }*/
    public void move(int y)
    {
        movement = new Vector2(speed.x * x, speed.y * y);
        GetComponent<Rigidbody2D>().velocity = movement;

    }
}
