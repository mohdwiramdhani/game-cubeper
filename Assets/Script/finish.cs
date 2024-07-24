using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour
{

    public Image bg;
    public GameObject ulang;
    public Text selesai;
    public GameObject jump;

    // Start is called before the first frame update
    void Start()
    {

        bg.enabled = false;
        ulang.SetActive(false);
        selesai.enabled = false;

    }

    void OnTriggerEnter2D(Collider2D obj)
    {

        if (obj.gameObject.tag == "Player")
        {

            bg.enabled = true;
            ulang.SetActive(true);
            selesai.enabled = true;
            jump.SetActive(false);
            Debug.Log("HIT TARGET");
            Destroy(obj.gameObject);

        }

    }



}
