using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASpawner : MonoBehaviour
{
    public GameObject AsteroidPrefab;

    public float MaxSpawnRateS = 10f;

    [SerializeField] float LSide = 0f;
    [SerializeField] float RSide = 0f;
    
    

    // Start is called before the first frame update
    void Start()
    {
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
        Enemy.transform.position = new Vector3(Random.Range(LSide, RSide), transform.position.y);


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
