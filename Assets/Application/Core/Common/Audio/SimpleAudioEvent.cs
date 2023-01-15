using UnityEngine;

[CreateAssetMenu(menuName = "AudioEvents(Simple)")]
public class SimpleAudioEvent : AudioEvent
{
    public AudioClip[] Clips;
    [Range(0f,1f)]
    public float Volume;
    
    [Range(-3f,3f)]
    public float Pitch;
    public override void PlayAudio(AudioSource source)
    {
        if (Clips.Length == 0) return;

        source.clip = Clips[0];
        source.volume = Volume;
        source.pitch = Pitch;
        source.Play();
    }
}