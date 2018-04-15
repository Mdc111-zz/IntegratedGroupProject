using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNearestStart : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.y)) + Vector3.up * 0.5f + Vector3.right * 0.5f;
        Destroy(this);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
