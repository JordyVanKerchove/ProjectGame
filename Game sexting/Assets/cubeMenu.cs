using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMenu : MonoBehaviour {

    // Use this for initialization
    public float speed = 10f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(speed,speed,speed) * Time.deltaTime);
	}
}
