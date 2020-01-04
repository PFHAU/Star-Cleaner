using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCol : MonoBehaviour
{
    Color spriteColor;
    Color colorNotmp;
    bool flash;
    Renderer rend;
    Color c;
    private BoxCollider2D shipC;
    // Start is called before the first frame update
    void Start()
    {
        shipC = this.GetComponent<BoxCollider2D>();
        rend = GetComponent<Renderer>();
        c= rend.material.color;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine("Invulnerability");
        if (GameObject.FindGameObjectWithTag("life1"))
            GameObject.FindGameObjectWithTag("life1").AddComponent<fadeOut>();
        else if (GameObject.FindGameObjectWithTag("life2"))
            GameObject.FindGameObjectWithTag("life2").AddComponent<fadeOut>();
        else if (GameObject.FindGameObjectWithTag("life3"))
            GameObject.FindGameObjectWithTag("life3").AddComponent<fadeOut>();
        else if (GameObject.FindGameObjectWithTag("life4"))
            GameObject.FindGameObjectWithTag("life4").AddComponent<fadeOut>();
        else if (GameObject.FindGameObjectWithTag("life5"))
        {
            GameObject.FindGameObjectWithTag("life5").AddComponent<fadeOut>();
            FindObjectOfType<gameManager>().EndGame();

        }


        /* for (int n = 0; n < 2; n++)
         {
             spriteColor.a = 0.0f;
             yield return new WaitForSeconds(0.1f);
             spriteColor.a=1.0f;
             yield return new WaitForSeconds(0.1f);
         }
         spriteColor = colorNotmp;*/

    }

    IEnumerator Invulnerability()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        c.a=0.5f;

        rend.material.color = c;
        yield return new WaitForSeconds(2f);
        Physics2D.IgnoreLayerCollision(8, 9, false);
        c.a = 1f;
        rend.material.color = c;

    }
}
