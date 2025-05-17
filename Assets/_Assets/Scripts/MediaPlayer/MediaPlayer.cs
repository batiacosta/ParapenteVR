
using UnityEngine;

[SerializeField]
public abstract class MediaPlayer: MonoBehaviour
{
    protected MediaManager.Media MediaType;
    protected State MediaState = State.Stopped;

    public enum State
    {
        Playing,
        Paused,
        Stopped
    }

    public MediaManager.Media GetMediaType() => MediaType;
    public abstract void SetMedia();
    public abstract void Play();
    public abstract void Pause();
    public abstract void Stop();
    public abstract void Next();
    public abstract void Previous();
    public abstract void Rewind();
    public abstract void FastForward();
    public abstract void RewindForward();
    public abstract void Seek();
    public abstract void Shuffle();
    public abstract void VolumeUp();
    public abstract void VolumeDown();
    
    
    
}
