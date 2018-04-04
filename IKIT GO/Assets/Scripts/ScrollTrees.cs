using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTrees : MonoBehaviour {

	public float speed = -2f;

	void Update(){
		transform.Translate (speed * Time.deltaTime, 0f, 0f);

		if (transform.position.x <= -10f) {
			transform.Translate (20f, 0f, 0f);
		}
	}
}
