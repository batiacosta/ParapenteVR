using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;

public class VideoPlayerController: MediaPlayer
{
    [SerializeField] private MediaManager.Media media;
    [SerializeField] private VideoPlayer videoPlayer;

    private void Awake()
    {
        base.MediaType = media;
    }

    private void Start()
    {

    }

    public override void SetMedia()
    {
        
    }

    public override void Play()
    {
        videoPlayer.Play();
    }

    public override void Pause()
    {
        videoPlayer.Pause();
    }

    public override void Stop()
    {
        videoPlayer.Stop();
    }

    public override void Next()
    {
        
    }

    public override void Previous()
    {
        
    }

    public override void Rewind()
    {
        
    }

    public override void FastForward()
    {
        
    }

    public override void RewindForward()
    {
        
    }

    public override void Seek()
    {
        
    }

    public override void Shuffle()
    {
        
    }

    public override void VolumeUp()
    {
        
    }

    public override void VolumeDown()
    {
        
    }

    public MediaPlayer.State GetState() => MediaState;
}