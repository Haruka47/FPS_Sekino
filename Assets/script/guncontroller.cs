using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guncontroller : MonoBehaviour {

	Vector3 center;
	// Use this for initialization
	void Start () {
		center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1"))
			fire ();
	}
		
	void fire() {
		Ray ray;
		RaycastHit hit;
		GameObject targetGameObject;

		ray = Camera.main.ScreenPointToRay (center);

		if (Physics.Raycast (ray, out hit, 1000)) {
			targetGameObject = hit.collider.gameObject;
			if (targetGameObject.tag == "Target") {
				Destroy (targetGameObject);

			} else {
				targetGameObject = null;
			}
		}


	}
}
