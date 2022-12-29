using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static Action CallAudioPlay;

    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
        CallAudioPlay += AudioPlay;
    }

    private void OnDestroy()
    {
        CallAudioPlay -= AudioPlay;
    }

    private void AudioPlay()
    {
        _source.Play();
    }
}