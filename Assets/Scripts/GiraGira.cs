using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraGira : MonoBehaviour {

    public float x, y, z;
	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 rotacao = new Vector3(x*Time.deltaTime, y*Time.deltaTime, z*Time.deltaTime); // x graus em x, y graus em y e z gruas em z
                                                                                                // deltaTime = tempo desda última vez q foi chamado
        transform.Rotate(rotacao);
	}
}
