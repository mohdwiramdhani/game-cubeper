using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontroller : MonoBehaviour
{

    private Rigidbody2D kontrol;

    private float kecepatan = 5f;
    public float upForce = 120f;

    public float dash = 15f;

    public float fallMultiplier = 2.5f;
    public float lowMultiplier = 2f;

    // Start is called before the first frame update



    void Start()
    {

        kontrol = GetComponent<Rigidbody2D>();
        kontrol.velocity = Vector2.right * kecepatan;

    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "small")
        {

            kontrol.velocity = Vector2.right * dash;
            Debug.Log("kena");

        }

        if (coll.gameObject.tag == "normal")
        {
            Debug.Log("normal");
            kontrol.velocity = Vector2.right * kecepatan;
        }

    }

    // Update is called once per frame
    void Update()
    {

        ModJump();

    }

    public void Jump()
    {

        kontrol.velocity = new Vector2(kontrol.velocity.x, upForce);

    }

    void ModJump()
    {

        if (kontrol.velocity.y < 0)
        {

            kontrol.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;

        }
        else if (kontrol.velocity.y > 0 && Input.GetKey(KeyCode.Space))
        {

            kontrol.velocity += Vector2.up * Physics2D.gravity * (lowMultiplier - 1) * Time.deltaTime;

        }

    }

}
