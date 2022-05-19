using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	Rigidbody rigid;
	
	private const float MAX_SPEED_ANGLE = -20;
	private const float ZERO_SPEED_ANGLE = 210;
	
	private Transform needleTransform;
	
	private float speedMax;
	private float speed;
	
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	
    void Start()
    {
        //needleTransform = transform.Find("Needle");
		
		//speed = 0f;
		//speedMax = 200f;
    }

    void Update()
    {
		//speed += 30f * Time.deltaTime;
		//if (speed > speedMax) speed = speedMax;
		
		//needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
		
		rigid = GameObject.Find("CAR").GetComponent<Rigidbody>();
		Vector3 velocity = rigid.velocity;
		Debug.Log("SPEED = " + velocity);
		
    }
	
	void OnGUI(){
		Vector3 velocity = rigid.velocity;
		GUI.Label (new Rect(Screen.width, Screen.height, 300, 50), velocity.ToString());
		guiStyle.fontSize = 250; //change the font size
        GUILayout.Label(velocity.ToString(), guiStyle);
	}
	
	/*private float GetSpeedRotation() {
		float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;
		float speedNormalized = speed / speedMax;
		return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
	}*/
}
