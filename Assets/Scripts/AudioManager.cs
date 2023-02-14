using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static public AudioManager instance;
    private List<GameObject> activeAudioGameObjects;
   

    void Awake()
    {
        if(instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            activeAudioGameObjects = new List<GameObject>();
            DontDestroyOnLoad(gameObject);
        }
    }

    public AudioSource PlayAudio(AudioClip clip, float volume = 1) //Reproducir audio.
    {
        GameObject sourceObj = new GameObject(clip.name);
        activeAudioGameObjects.Add(sourceObj);
        sourceObj.transform.SetParent(this.transform);
        AudioSource source = sourceObj.AddComponent<AudioSource>();
        source.clip = clip;
        source.volume = volume;
        source.Play();
        StartCoroutine(PlayAudio(source));
        return source;
    }

    public AudioSource PlayAudioOnLoop (AudioClip clip, float volume = 1)// Reproducir audio en bucle.
    {
        GameObject sourceObj = new GameObject(clip.name); //Para crear nuevo objeto.
        activeAudioGameObjects.Add(sourceObj); //Añadir el audio al objeto.
        sourceObj.transform.SetParent(this.transform); //Le hace hijo.
        AudioSource source = sourceObj.AddComponent<AudioSource>();
        source.clip = clip;
        source.volume = volume;
        source.loop = true;
        source.Play();
        return source;
    }

    public void ClearAudioList() //Para limpiar el audio.
    {
        foreach (GameObject go in activeAudioGameObjects) 
        {
            Destroy(go);
        }
        activeAudioGameObjects.Clear();
    }

    IEnumerator PlayAudio(AudioSource source)
    {
        while (source && source.isPlaying)
        {
            yield return null;

        }
        if (source)
        {
            activeAudioGameObjects.Remove(source.gameObject);
            Destroy(source.gameObject);
        }
    }
}


