using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyGameObject;
    public int enemyIndex = 0;
    public int wave = 1;

    private int spawnRangeY = 5;
    private int spawnRangeX = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wave < 3) 
        {
            SpawnEnemy();
            wave++;
        }
        
    }

    private void SpawnEnemy() 
    {
        Vector3 spawnPos = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX),
            Random.Range(-spawnRangeY, spawnRangeY),
            0
            );

        Instantiate(
            enemyGameObject[enemyIndex],
            spawnPos,
            enemyGameObject[enemyIndex].transform.rotation
            );
    }
}
