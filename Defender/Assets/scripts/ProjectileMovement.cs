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

        Vector2 top = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if (transform.position.y > top.y)
        {
            Destroy(gameObject);
        }
    }

    



}
