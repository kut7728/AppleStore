using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelebrateSpawn : MonoBehaviour
{
    public GameObject go;
    public Transform point;
    public Transform parent;
    // public float delayInSeconds = 1.0f;
    int objCounter = 0;
    public AudioSource m_MyAudioSource;

    void Start()
    {
    }

    public void Celebrate()
    {
        InvokeRepeating("objSpawn", 0, 0.1f);

        if (objCounter == 100) {
            CancelInvoke("objSpawn");
        }
    }

    // IEnumerator objSpawn() {
    //     yield return new WaitForSeconds(delayInSeconds);
    //     // GameObject spawnobj = Instantiate(go, point.position, point.rotation, parent);
    //     Instantiate(go, point.position, point.rotation, parent);
    // }
    
    void objSpawn() {
        Instantiate(go, point.position, point.rotation, parent);
        objCounter += 1;
    }

    public void PlayAudio()
    {
        m_MyAudioSource.Play();
    }


}
