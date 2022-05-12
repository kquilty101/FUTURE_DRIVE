using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	Rigidbody rigid;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		rigid = GameObject.Find("CAR").GetComponent<Rigidbody>();
		Vector3 velocity = rigid.velocity;
		Debug.Log("velocity = " + velocity);
    }
}
