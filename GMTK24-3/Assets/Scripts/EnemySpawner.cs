using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject toSpawn;
    public float spawnCooldown = 2;

    void Start()
    {
        StartCoroutine(SpawnCountdown());
    }

    private IEnumerator SpawnCountdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnCooldown); 
            if(spawnCooldown >= 0.8) spawnCooldown -= 0.08f;

            Instantiate(toSpawn,new Vector2(
                Random.Range(-7,8),
                5
            ), Quaternion.identity);
        }
    }
}
