using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    float position;
    Rigidbody2D rgbd;
    SpriteRenderer sprite;
    public string color = "blue";

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position.x;
        rgbd = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rgbd.velocity=(movement * speed);
        if (rgbd.velocity != new Vector2 (0, 0))
        {
            sprite.color = UnityEngine.Color.red;
            color = "red";
        }else
        {
            sprite.color = UnityEngine.Color.blue;
            color = "blue";
        }
    }

    public void Stealth()
    {
        if (color == "blue")
        {
            this.Die();
        }
    }

    public void Die()
    {
        transform.position = new Vector2(position,0);
    }

}
