using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berger : MonoBehaviour
{

    public Rigidbody2D engine;

    // Start is called before the first frame update
    void Start()
    {

        engine = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector2(0, horizontalInput);
        engine.AddForce(direction);
        
    }
}
