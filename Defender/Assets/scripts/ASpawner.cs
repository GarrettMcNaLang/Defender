using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASpawner : MonoBehaviour
{
    public GameObject Asteroid;

    public float SpawnRate = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", SpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to spawn the enemy
    void SpawnEnemy()
    {
        //Bottom left point of the screen
        Vector3 min = Camera.main.ViewportToWorldPoint (new Vector3(-5, 0));

        //Top right point of the screen
        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1, 1));

        //instantiates the enemy
        GameObject Enemy = (GameObject)Instantiate (Asteroid);
        Enemy.transform.position = new Vector2(Random.Range (min.x, max.x), min.y);
    }
}
