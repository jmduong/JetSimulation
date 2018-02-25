using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{

    public GameObject Effect_02;
    private GameObject EffectReference;
    public int score;

    void OnCollisionEnter(Collision other)
    {
        score++;
        Destroy(gameObject);
    }

    IEnumerator DelayEffects()
    {
        yield return new WaitForSeconds(2.0f);
    }
}
