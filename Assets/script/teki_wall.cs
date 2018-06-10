using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teki_wall : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		Destroy (gameObject);
	}
}
