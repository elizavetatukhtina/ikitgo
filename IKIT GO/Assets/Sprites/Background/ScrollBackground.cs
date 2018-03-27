using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {

	public float speed = -2f;

	void Update(){
		transform.Translate (speed * Time.deltaTime, 0f, 0f);

		if (transform.position.x <= -17.7) {
			transform.Translate (35.4f, 0f, 0f);
		}
	}
}
