using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASpawner : MonoBehaviour
{
    public GameObject AsteroidPrefab;

    public float MaxSpawnRateS = 10f;

    private Vector2 confinesL;
    private Vector2 confinesR;

    // Start is called before the first frame update
    void Start()
    {
       confinesL = Camera.main.WorldToScreenPoint(new Vector3(-6.2f, -0.00f ));
        confinesR = Camera.main.WorldToScreenPoint(new Vector3(5.81f, -0.00f ));
        Invoke("SpawnEnemy", MaxSpawnRateS);

        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //function to spawn the enemy
    void SpawnEnemy()
    {


        //instantiates the enemy
        GameObject Enemy = (GameObject)Instantiate(AsteroidPrefab);
        Enemy.transform.position = new Vector2(Random.Range(confinesL.x, confinesR.x), confinesL.y);

        NextSpawn();
    }

    void NextSpawn()
    {
        float spawnInSeconds;
        if (MaxSpawnRateS > 1f)
        {
            spawnInSeconds = Random.Range(1f, MaxSpawnRateS);
        }
        else
        {
            spawnInSeconds = 1f;
            Invoke("SpawnEnemy", spawnInSeconds);
        }
    }

    void IncreaseSpawnRate()
    {
        if (MaxSpawnRateS > 1f)
        {
            MaxSpawnRateS--;
        }

        if (MaxSpawnRateS == 1f)
        {
            CancelInvoke("IncreaseSpawnRate");
        }
    }
}
