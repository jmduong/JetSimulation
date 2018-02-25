using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randEnemy = Random.Range(0, 1);
            Vector3 spawnPosition = Random.insideUnitSphere * (Random.Range(spawnValues.x, spawnValues.x));

            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            Debug.Log(spawnPosition + transform.TransformPoint(0, 0, 0));
            yield return new WaitForSeconds(spawnWait);
        }
    }
}