using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPadelScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D lp;
    void Start()
    {
        lp = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {

            lp.velocity = new Vector2(0f, Input.GetAxis("Vertical") * 20);
        }
        
    }
}
