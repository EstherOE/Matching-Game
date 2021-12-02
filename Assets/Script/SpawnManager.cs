using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] foodSpawn;
    public Transform point1;
    public Transform point2;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave();
    }

   
    void SpawnEnemyWave()
    {

        for (int j = 0; j < foodSpawn.Length; j++) {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(foodSpawn[j], GenerationPoint(), transform.rotation);



            }
        }
    }
    private Vector3 GenerationPoint()
    {

        float spawnPosx = Random.Range(-12.8f, 14.7f);
        float spawnPosz = Random.Range(-3f, 5.43f);
        Vector3 randomPos = new Vector3(spawnPosx, 0.53f, spawnPosz);

        return randomPos;
    }
}
