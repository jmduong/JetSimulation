using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour {

    public GameObject Effect_02;
    private GameObject EffectReference;

    void OnCollisionEnter(Collision other)
    {
        EffectReference = Instantiate(Effect_02, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    IEnumerator DelayEffects()
    {
        yield return new WaitForSeconds(2.0f);
    }
}
