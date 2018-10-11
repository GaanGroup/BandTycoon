using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Transform tr;
    private Transform cameraTr;

	// Use this for initialization
	void Start () {
        tr = transform;
        cameraTr = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
