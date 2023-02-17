using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    [SerializeField] float leftBoundary = 0f;
    [SerializeField] float rightBoundary = 0f;
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
        //checks for input
    {   //difference between GetKey vs. GetKeyDown: GetKey returns true for every frame
        //you have it down, while GetKeyDown will only return true for the first frame you
        //get the key down
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }

        //creates a boundary on the left and right side of the screen
        if(transform.position.x >= rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        else if(transform.position.x <= leftBoundary)
        {
            transform.position = new Vector3(leftBoundary,transform.position.y, transform.position.z);
        }
        //limiter reference from the coordinates of the x-axis will be used from the
        //position of the object in the inspector, without editing the script
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
