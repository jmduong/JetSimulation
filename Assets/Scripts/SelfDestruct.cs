using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waitSpawner());
    }


    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
    }
}