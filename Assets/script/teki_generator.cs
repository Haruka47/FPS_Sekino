using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teki_generator : MonoBehaviour {

	float interval;
	float interval_add = 0;
	float interval_addtime = 100;

	Rigidbody rb;

	public GameObject targetPrefab;

	private float targetVelosity = 3;
	private float timer;
	private float intervalTimer;

	// Use this for initialization
	void Start () {
		timer = 0f;
		interval = 2;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer < 0f) {
			float offsetX = Random.Range (0, 250);
			float offsetY = Random.Range (1, 3);
			float offsetZ = Random.Range (0, 250);

			Vector3 position = new Vector3 (offsetX, offsetY, offsetZ);
			GameObject prefab = targetPrefab;
			GameObject target = Instantiate (prefab, position, transform.rotation);

			Vector3 direction;

			GameObject player = GameObject.FindWithTag("chara");
			if (player != null) {
				direction = (player.transform.position - target.transform.position).normalized;
				rb = target.GetComponent<Rigidbody>();
				rb.AddForce (direction * targetVelosity, ForceMode.VelocityChange);
			}
			timer = interval;
		}

		intervalTimer += Time.deltaTime;
		if (intervalTimer > interval_addtime) {
			intervalTimer = 0f;
			interval -= interval_add;
		}
		
	}
}
