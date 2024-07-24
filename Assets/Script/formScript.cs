using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formScript : MonoBehaviour
{

    public Sprite smallSprite;
    public Sprite normalSprite;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D ob)
    {

        if (ob.gameObject.tag == "small")
        {

            Debug.Log("OY");
            player.transform.localScale = new Vector2(1f, 1f);


        }

        if (ob.gameObject.tag == "normal")
        {

            player.transform.localScale = new Vector2(2f, 2f);

        }

    }
}
