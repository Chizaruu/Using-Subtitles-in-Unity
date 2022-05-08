using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class VoiceManager : MonoBehaviour
{
    [SerializeField]private AudioClip[] voiceLines;
    [SerializeField]private int currentVoiceLine = 0;
    [SerializeField]private AudioSource voice;

    private void Start()
    {
        StartCoroutine(PlayVoiceLines());
    }
    private IEnumerator PlayVoiceLines()
    {
        while (currentVoiceLine < voiceLines.Length)
        {
            voice.clip = voiceLines[currentVoiceLine];
            voice.Play();
            yield return new WaitForSeconds(voice.clip.length);
            currentVoiceLine++;
        }
    }
}
