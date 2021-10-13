using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantManager : MonoBehaviour
{
    public static PersistantManager Instance { get; private set; }

    public int Value;
    public AudioSource clip;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound()
    {
        clip.Play();
    }
}
