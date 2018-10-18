using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarSom : MonoBehaviour
{

    public AudioClip som;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (som != null)
        {
            GameObject s = GameObject.FindGameObjectWithTag("Som");
            s.GetComponent<AudioSource>().clip = som;
            s.GetComponent<AudioSource>().Play();
        }
    }
}
