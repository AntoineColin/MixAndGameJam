using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{
    public float speed;
    float savedPosition;
    Rigidbody2D rgbd;
    SpriteRenderer sprite;
    public UnityEngine.Color color;
    public string disguise = "blue";
    public UnityEvent onDeath = new UnityEvent();

    public void SetDisguise(string disguise)
    {
        this.disguise = disguise;
    }

    

    // Start is called before the first frame update
    void Start()
    {
        savedPosition = transform.position.x;
        rgbd = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rgbd.velocity=(movement * speed);
        if(rgbd.velocity != Vector2.zero && sprite.color != Color32.Lerp(color, Color.white, 0.5f)){
            sprite.color = Color32.Lerp(color, Color.white, 0.5f);
        }
        if(rgbd.velocity == Vector2.zero && sprite.color != color)
        {
            sprite.color = color;
        }
        
    }

    public void Stealth(Color32 ennemyColor)
    {
        if (ennemyColor != sprite.color)
        {
            this.Die();
        }
    }

    public void Die()
    {
        transform.position = new Vector2(savedPosition,0);
        if (onDeath != null) onDeath.Invoke();
    }

    public void SavePosition(float xpos)
    {
        savedPosition = xpos;
    }
}
