using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float posY = gameObject.transform.position.y-5;
		Vector3 original = gameObject.transform.position;
		if (OVRInput.GetDown (OVRInput.Button.One)) {
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x, posY, gameObject.transform.position.z);
		} else {
			gameObject.transform.position = original;
		}
	}	
}
