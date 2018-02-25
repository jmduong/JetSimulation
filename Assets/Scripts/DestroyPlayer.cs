using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{

    public GameObject Effect_02;
    private GameObject EffectReference;
    public int score;

    void OnCollisionEnter(Collision other)
    {
        EffectReference = Instantiate(Effect_02, transform.position, Quaternion.identity);        
    }

    IEnumerator DelayEffects()
    {
        yield return new WaitForSeconds(2.0f);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
