using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class gameManager : MonoBehaviour
{
    private Vector2 screenBounds;
    private Vector3 tmpPos;
    private int nbAst;
    private int nbStar;
    private int nbBlackHole;
    int limit;
    int limitStar;
    int limitBlackHole;
    //public Text score;

    float tmppos2;
    // Start is called before the first frame update
    void Start()
    {
        limit = 15;
        limitStar = 60;
        limitBlackHole = 2;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //InvokeRepeating("spawnAsteroid", 2.0f, 1.0f);
        SpawnAsteroid();
        SpawnStar();
    }

    private void SpawnBlackHole()
    {
        tmpPos = new Vector3(Random.Range(screenBounds.x * 2, screenBounds.x * 5), Random.Range(-screenBounds.y, screenBounds.y), -1);
        GameObject gb= Instantiate(Resources.Load("blackHole"), tmpPos, Quaternion.identity) as GameObject;
    }

    private void SpawnAsteroid()
    {

        tmpPos = new Vector3(Random.Range(screenBounds.x * 2, screenBounds.x * 5), Random.Range(-screenBounds.y, screenBounds.y), -1);
        GameObject gy = Instantiate(Resources.Load("asteroid"), tmpPos, Quaternion.identity) as GameObject;
        
    }
    
    private void SpawnStar()
    {
        tmpPos = new Vector3(Random.Range(screenBounds.x * 2, screenBounds.x * 5), Random.Range(-screenBounds.y, screenBounds.y), Random.Range(1, 5));
        GameObject gs = Instantiate(Resources.Load("Star"), tmpPos, Quaternion.identity) as GameObject;
        tmppos2 = gs.transform.position.z/2;
        gs.transform.localScale = new Vector3(tmppos2, tmppos2, tmppos2);
    }



    void Update()
    {
        nbAst=GameObject.FindGameObjectsWithTag("Enemy").Length;
        nbStar = GameObject.FindGameObjectsWithTag("Star").Length;
        nbBlackHole = GameObject.FindGameObjectsWithTag("BlackHole").Length;

        int shootingStarRatio = Random.Range(0, 200);
        if (shootingStarRatio == 10)
        {
            ShootingStarGo();
        }

        if (nbAst < limit)
        {
            SpawnAsteroid();
        }
        if (nbStar < limitStar)
        {
            SpawnStar();
        }
        if (nbBlackHole < limitBlackHole && int.Parse(GameObject.FindWithTag("scoreLabel").GetComponent<Text>().text) > 2)
        {
            SpawnBlackHole();
        }
    }

    void ShootingStarGo()
    {
        tmpPos = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y), 1);
        GameObject gs = Instantiate(Resources.Load("ShootingStar"), tmpPos, Quaternion.identity) as GameObject;
        tmppos2 = gs.transform.position.z / 2;
        gs.transform.localScale = new Vector3(tmppos2, tmppos2, tmppos2);

        float speed = gs.GetComponent<Transform>().position.z *10;
        Rigidbody2D rb = gs.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

   }

   public void EndGame()
    {
        int score =int.Parse(GameObject.FindWithTag("scoreLabel").GetComponent<Text>().text);
        int hS = PlayerPrefs.GetInt("HighScore", 0);
        if (score > hS)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        SceneManager.LoadScene("GameOver");
    }
}
