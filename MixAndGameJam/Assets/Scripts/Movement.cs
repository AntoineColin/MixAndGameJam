using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    float position;
    Rigidbody2D rgbd;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position.x;
        rgbd = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rgbd.velocity=(movement * speed);
    }
}
