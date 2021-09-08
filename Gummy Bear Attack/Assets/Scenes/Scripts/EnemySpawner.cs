using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyFab;
    public float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0) {
        Instantiate(enemyFab, transform.position, Quaternion.identity);
        spawnTimer = 5f;
        }
    }
}
