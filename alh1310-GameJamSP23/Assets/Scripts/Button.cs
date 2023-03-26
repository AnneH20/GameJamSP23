using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioClip button;
    public string sceneName;

    void Start()
    {
        Time.timeScale = 1;
    }
    public void playSound()
    {
        buttonSound.PlayOneShot(button);
        StartCoroutine(_playSound());
    }

    private IEnumerator _playSound()
    {
        yield return new WaitForSeconds(button.length);
        SceneManager.LoadScene(sceneName);
        Debug.Log("Changing to scene: " + sceneName);
    }

    /*
    public void LoadScene(string sceneName)
    {
        buttonSound.Play();
        SceneManager.LoadScene(sceneName);

    }
    */
}
