using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    //variable that holds the projectile prefab
    public GameObject Projectile;
    public Transform ProjectileSpawn;
    //the time interval between each shot
    public float nextFire = 1.0f;
    //checks current time and checks to see if it is 1.0 before firing
    public float currentTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        //finds game object attached to it and gets the transform of it.
        ProjectileSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        currentTime += Time.deltaTime;

        //input for button
        //current time is at zero and is built upon by delta time
        //larger than nextfire means we can fire(1 second)
        if(Input.GetKey(KeyCode.Space) && currentTime > nextFire)
        {
            //adds current time so as to not shoot again
            //nextFire += currentTime;
            //shoot and creat the object
            //Quaternion identity means to no rotation, so it is perfectly on an axis
            Instantiate(Projectile, ProjectileSpawn.position, Quaternion.identity);
            //after projectile is made, current time is subtracted so 
            //that it's valid in time interval
            //nextFire -= currentTime;
            //starts over current time
            currentTime = 0.0f;
        }
    }
}
