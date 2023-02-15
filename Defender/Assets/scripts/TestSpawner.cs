using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawner;
    [SerializeField]
    private GameObject Prefab;
    [SerializeField]
    private float Interval = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private IEnumerator spawnEnemy(float interval, GameObject prefab)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(Prefab, new Vector3(Random.Range(5f, 5), Random.Range(6f, 6), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, newEnemy));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
