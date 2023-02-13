using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    
    public Rigidbody2D projectile;

    public float MoveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(0, 1) * MoveSpeed;

        
    }

    //destroys enemy on collision with projectile
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "asteroid")
        {
            Destroy(gameObject);
        }
    }
    
}
