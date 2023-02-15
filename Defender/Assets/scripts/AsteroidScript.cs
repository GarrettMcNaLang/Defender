using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public Transform Object;
    public float speed;
    private Vector2 screenborders;
    
 // private ASpawner spawner;
    
    // Start is called before the first frame update
    void Start()
    {
        screenborders = Camera.main.WorldToScreenPoint(Object.position);
    }

    // Update is called once per frame
    void Update()
    {   //Get the asteroids current position
        Vector2 position = transform.position;

        //Compute the new position
        position = new Vector2 (position.x, position.y - speed * Time.deltaTime);

        //Update the position
        transform.position = position;

        //Bottom left point of the screen
        


        //destroys the gameobject if it goes off the screen
        if (transform.position.y < screenborders.y * 2)
        {
            Destroy(gameObject);
        }
    }
}
