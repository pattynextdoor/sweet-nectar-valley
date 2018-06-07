using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayMessage : MonoBehaviour {
	[SerializeField]
	private TextMeshProUGUI text;

	void Awake(){
		text.enabled = false;
	}

	void OnTriggerStay(Collider other)
	{
		//display message
		text.enabled = true;
		Debug.Log ("HERE IN COLLIDER");
	}
	void OnTriggerExit(Collider other)
	{
		text.enabled = false;
	}
}
