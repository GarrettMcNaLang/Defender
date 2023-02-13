using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
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
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));


        //destroys the gameobject if it goes off the screen
        if(transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }
}
