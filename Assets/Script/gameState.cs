using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameState : MonoBehaviour
{
    private int scorePlayer = 0;

   // private gameState(){}

    private static gameState _instance;

   /* public static gameState Instance()
    {
        if(instance == null)
        {
            instance = new gameState();
        }
        return instance;
    }*/
    public static gameState Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;

        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        GameObject.FindWithTag("scoreLabel").GetComponent<Text>().text = "" + scorePlayer;

    }

    public void addScorePlayer(int toAdd)
    {
        
        scorePlayer += toAdd;
    }

    public int getScorePlayer()
    {
        return scorePlayer;
    }
}
