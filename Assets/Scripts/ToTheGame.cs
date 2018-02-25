using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheGame : MonoBehaviour {

    private void Update()
    {
        print("alright");
        // returns true if the primary button (typically “A”) was pressed this frame.
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            PlayGame();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
