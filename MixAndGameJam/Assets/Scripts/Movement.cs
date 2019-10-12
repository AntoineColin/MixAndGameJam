using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    float position;
    Rigidbody2D rgbd;
    SpriteRenderer sprite;
    public UnityEngine.Color color;
    public string disguise = "blue";

    public void SetDisguise(string disguise)
    {
        this.disguise = disguise;
    }

    

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
        switch (disguise)
        {
            case "blue":
                if (rgbd.velocity != new Vector2(0, 0))
                {
                    sprite.color = new Color32(255,97,97,255);
                    color = sprite.color;
                }
                else
                {
                    sprite.color = UnityEngine.Color.blue;
                    color = sprite.color;
                }
                break;

            case "red":
                if (rgbd.velocity != new Vector2(0, 0))
                {
                    sprite.color = UnityEngine.Color.magenta;
                    color = sprite.color;
                }
                else
                {
                    sprite.color = UnityEngine.Color.red;
                    color = sprite.color;
                }
                break;
        }
        
    }

    public void Stealth(Color32 ennemyColor)
    {
        if (ennemyColor != this.color)
        {
            this.Die();
        }
    }

    public void Die()
    {
        transform.position = new Vector2(position,0);
    }

}
