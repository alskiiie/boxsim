using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {


    public static float speed = 1.2f;
    public bool reverse = false;
    public float personalSpeed;

    // Use this for initialization
    void Start () {
            
    
	}
	
	// Update is called once per frame
	void Update () {

        personalSpeed = speed;
        if (reverse)
        {
            personalSpeed *= -1;
        }


    transform.Rotate(new Vector3(0f, 0f, personalSpeed));
	}

    public void AdjustSpeed (float newspeed)
    {
        speed = newspeed;
    }
}
