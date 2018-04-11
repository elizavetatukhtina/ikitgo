using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nut : MonoBehaviour {

    public float speed = -3f;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0f, 0f); // implements a movement at an angle 
    }

    void OnCollisionEnter2D( Collision2D c )
    {
        if(c.gameObject.name == "ground" || c.gameObject.name == "ice")
        {
            NutControll.instance.NutCreate();
            Destroy(gameObject);
        }
    }
}
