using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionsMenu : MonoBehaviour
{
    public AudioMixer taustaMusiikki;

    public void SetVolume (float volume)
    {
        taustaMusiikki.SetFloat("TaustaMusiikki", volume);

    }
}
