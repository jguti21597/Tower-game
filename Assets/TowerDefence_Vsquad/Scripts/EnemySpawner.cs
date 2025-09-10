using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject goblinprefab;
    [SerializeField]
    private float minSpawnTime;
    [SerializeField]
    private float maxSpawnTime;

    private float timetoSpawn;
    // Start is called before the first frame update
    void Awake()
    {
        SetTimeTilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timetoSpawn = timetoSpawn - Time.deltaTime;

        if (timetoSpawn <= 0) {
            Instantiate(goblinprefab, transform.position, Quaternion.identity);
            SetTimeTilSpawn();
        }
    }

    private void SetTimeTilSpawn() {
        timetoSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }
        
}
