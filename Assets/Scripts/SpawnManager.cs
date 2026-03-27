using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
        //InvokeRepeating(nameof(RandomSpawn), 0, 5);

        //StartCoroutine(Hello());
        //StartCoroutine(GoodBye());
    }

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            RandomSpawn();
            yield return new WaitForSeconds(3);
        }
    }

    void RandomSpawn()
    {
        var index = Random.Range(0, spawnPoints.Length);
        var spawnPoint = spawnPoints[index];
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }

    /*IEnumerator GoodBye()
    { 
        yield return new WaitForSeconds(1);
        Debug.Log("Bye " + Time.frameCount + " " + Time.time);
    }

    IEnumerator Hello()
    {
        Debug.Log("Hello " + Time.frameCount);
        yield return null;
    }*/
}
