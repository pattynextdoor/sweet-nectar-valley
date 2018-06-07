using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoInside : MonoBehaviour {
	void OnTriggerStay(Collider other)
	{
		//If B is pressed, change to indoor scene
		if (OVRInput.GetDown (OVRInput.Button.Two)) {
			//Switch to indoor scene
			Debug.Log("Enter the house");
			SceneManager.LoadScene ("indoor");
		}
	}
}
