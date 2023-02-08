using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    //reference to a 2D rigidbody
    public Rigidbody2D projectile;

    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        projectile = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(0,1) * moveSpeed;
    }
}
