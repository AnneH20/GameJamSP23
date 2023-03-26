using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioClip button;

    public void playQuitSound()
    {
        buttonSound.PlayOneShot(button);
        StartCoroutine(_playQuitSound());
    }

    private IEnumerator _playQuitSound()
    {
        yield return new WaitForSeconds(button.length);
        Application.Quit();
    }

}
