using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheMenu : MonoBehaviour
{

    private void Update()
    {
        print("alright");
        // returns true if the primary button (typically “A”) was pressed this frame.
        if (OVRInput.Get(OVRInput.Button.Four))
        {
            PlayAgain();
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
