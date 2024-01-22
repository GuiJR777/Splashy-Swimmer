using System.Collections.Generic;
using UnityEngine;

public class MusicManager: MonoBehaviour
{
    private static MusicManager instance = null;

    public List<AudioClip> musicClips = new List<AudioClip>();

    private int currentMusicIndex = 0;

    public static MusicManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        PlayRandomMusic();
    }

    void Update()
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            currentMusicIndex = (currentMusicIndex + 1) % musicClips.Count;
            PlayRandomMusic();
        }
    }

    public void PlayMusic(int musicIndex)
    {
        if (musicIndex < 0 || musicIndex >= musicClips.Count)
        {
            Debug.LogError("Music index " + musicIndex + " is out of range");
            return;
        }

        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        audioSource.clip = musicClips[musicIndex];
        audioSource.Play();
    }

    public void PlayRandomMusic()
    {
        int randomMusicIndex = Random.Range(0, musicClips.Count);
        currentMusicIndex = randomMusicIndex;
        PlayMusic(randomMusicIndex);
    }
}