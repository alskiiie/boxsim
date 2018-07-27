using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public float startTime;
    public float Interval;

    public Rigidbody2D traveler;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Create", startTime, Interval);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Create()
    {
        Instantiate(traveler, new Vector3(-6.5f, 5.5f, 0), Quaternion.identity);
    }
}
