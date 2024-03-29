using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosX = -33;
    private float spawnRangeZ = 6;
    private float startDelay = 3;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, 15));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
