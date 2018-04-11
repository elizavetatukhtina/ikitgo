using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutControll : MonoBehaviour {

    public static NutControll instance;
    public Object nut;
    public GameObject squire;
    private GameObject nutClone;



	// Use this for initialization

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

	void Start () {
        NutCreate();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void NutCreate()
    {
        nutClone = (GameObject)Instantiate(nut);
        //nutClone.AddComponent<Rigidbody2D>();
        //do start position as position squire  
        nutClone.transform.position = new Vector2(squire.transform.position.x, squire.transform.position.y);
        nutClone.SetActive(true);
    }
}
