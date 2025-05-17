using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayPauseButton : MonoBehaviour
{
    [SerializeField] private Sprite[] icons;
    [SerializeField] private Image iconDisplay;
    private bool _isPlaying = false;

    private void Start()
    {
        iconDisplay.sprite = icons[0];
    }

    public void Execute()
    {
        _isPlaying = !_isPlaying;
        if (_isPlaying)
        {
            Play();
        }
        else
        {
            Pause();
        }
    }

    public void Play()
    {
        iconDisplay.sprite = icons[1];
        MediaManager.Play();
    }

    private void Pause()
    {
        iconDisplay.sprite = icons[0];
        MediaManager.Pause();
    }
    
}
