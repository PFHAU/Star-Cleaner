using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShoot : MonoBehaviour
{
    //public GameObject FloatingScore;
    public Vector2 speed;
    private Vector2 movement;
    public float x;
    public float y;
    public Vector2 screenBounds;

    /*private static moveShoot _instance;//XXX//
    public static moveShoot Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new moveShoot();
            }
            return _instance;
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        speed = GameObject.FindGameObjectWithTag("Player").GetComponent<moveShip>().speed;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {

        movement = new Vector2(speed.y *2, 0);
        GetComponent<Rigidbody2D>().velocity = movement;
        if (gameObject.transform.position.x > (screenBounds.x + (0.5 * screenBounds.x)))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.gameObject.AddComponent<fadeOut>();
        Destroy(collision.gameObject);
        Destroy(gameObject);
        gameState.Instance.addScorePlayer(1);
        PopUpFloatingScore(collision.gameObject);

    }

    private void PopUpFloatingScore(GameObject Enemy)
    {

       
        if (Enemy.tag == "Enemy")
        {
        Instantiate(Resources.Load("FloatingScore"), Enemy.transform.position , Quaternion.identity);
        }
    }
}
