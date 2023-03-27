using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public static MusicController instance = null;
    public AudioClip[] mainMenuSongs;
    public AudioClip[] playSongs;
    public AudioSource audioSource;

    private AudioClip[] currentSongs;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        currentSongs = mainMenuSongs;
        audioSource.clip = currentSongs[Random.Range(0, currentSongs.Length)];
        audioSource.Play();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "MainMenu" || scene.name == "About" || scene.name == "Settings")
        {
            if (currentSongs != mainMenuSongs)
            {
                currentSongs = mainMenuSongs;
                audioSource.clip = currentSongs[Random.Range(0, currentSongs.Length)];
                audioSource.Play();
            }
        }
        else if (scene.name == "Play")
        {
            if (currentSongs != playSongs)
            {
                currentSongs = playSongs;
                audioSource.clip = currentSongs[Random.Range(0, currentSongs.Length)];
                audioSource.Play();
            }
        }
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = currentSongs[Random.Range(0, currentSongs.Length)];
            audioSource.Play();
        }
    }
}
