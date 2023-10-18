using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }
    private AudioSource audioS;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        audioS = GetComponent<AudioSource>();
    }
    public void AudioPlay(AudioClip clip)
    {
        audioS.PlayOneShot(clip);
    }
}
