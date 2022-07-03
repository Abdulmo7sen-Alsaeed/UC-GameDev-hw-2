using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPadelScript : MonoBehaviour
{ // Start is called before the first frame update
    Rigidbody2D rp;
    void Start()
    {
        rp = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {

            rp.velocity = new Vector2(0f, Input.GetAxis("Vertical") * 20);
        }

    }
}
