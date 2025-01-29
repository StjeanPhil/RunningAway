using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    // prefab of the enemy
    [SerializeField] private GameObject enemyPrefab;

    // time between enemy spawns
    [SerializeField] private float spawnTime = 2f;

    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // spawn an enemy every spawnTime seconds
        time += Time.deltaTime;
        if (time >= spawnTime)
        {
            SpawnEnemy();
            time = 0;
        }
        
    }

    // spawn an enemy
    public void SpawnEnemy()
    {
        // create a new enemy
        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemy.GetComponent<Enemy>().player = GameObject.Find("Player");
    }
}
