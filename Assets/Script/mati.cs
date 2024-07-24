using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mati : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D obje)
    {

        if (obje.gameObject.tag == "blok")
        {

            SceneManager.LoadScene("scene1");

        }

    }

}
