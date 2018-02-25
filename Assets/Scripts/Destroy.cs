using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    public GameObject Effect_02;
    private GameObject EffectReference;
    public int score;

    void OnCollisionEnter(Collision other)
    {
        score++;
        EffectReference = Instantiate(Effect_02, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    IEnumerator DelayEffects()
    {
        yield return new WaitForSeconds(2.0f);
    }
}
