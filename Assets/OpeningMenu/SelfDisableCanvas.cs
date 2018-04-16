using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDisableCanvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("DisableCanvas", 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void DisableCanvas()
    {
        gameObject.SetActive(false);
    }
}
