using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scuseme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
        else if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5);
        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
        else if (Input.GetKey(KeyCode.A))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
    }
}
