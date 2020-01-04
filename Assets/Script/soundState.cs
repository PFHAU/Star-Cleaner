using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundState : MonoBehaviour
{
    public AudioClip playerShotSound;
    bool sp;
    //private soundState() { }

    private static soundState _instance;
    //private static soundState Instance = new soundState();

    public static soundState Instance
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


    public void TouchButtonSound()
    {
        MakeSound(playerShotSound);
    }

    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }

 /*  private void Update()
    {
        sp = Input.GetKeyDown(KeyCode.Space);
        if (sp)
        {

        }
    }*/
}
