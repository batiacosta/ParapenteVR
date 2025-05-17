using System;
using System.Collections.Generic;
using UnityEngine;

public class MediaManager : MonoBehaviour
{

    [SerializeField] private MediaPlayer[] mediaPlayers;
    public enum Media
    {
        None,
        Video,
        Audio
    }
    private Media _mediaType = Media.None;
    private Dictionary<Media, MediaPlayer> _mediaPlayers = new Dictionary<Media, MediaPlayer>();
    private static MediaPlayer _currentMediaPlayer = null;
    private void Start()
    {
        FillMediaDictionary();
        SetMedia(Media.Video);
    }

    private void FillMediaDictionary()
    {
        foreach (var mediaPlayer in mediaPlayers)
        {
            _mediaPlayers.Add(mediaPlayer.GetMediaType(), mediaPlayer);
            Debug.Log($"{mediaPlayer.GetMediaType()} key is added to dictionary");
        }
        Debug.Log($"{_mediaPlayers.Count}");
    }

    public void SetMedia(Media mediaType)
    {
        _mediaType = mediaType;
        _currentMediaPlayer = _mediaPlayers[_mediaType];
        Stop();
    }

    public static void Play()
    {
        _currentMediaPlayer?.Play();
    }
    public static void Stop()
    {
        _currentMediaPlayer?.Stop();
    }

    public static void Pause()
    {
        _currentMediaPlayer?.Pause();
    }
}
