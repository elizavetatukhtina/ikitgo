using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	



public class GameControll : MonoBehaviour {

	public static GameControll instance;
	//public GameObject gameOverText;	
	//public Text timeAndRe;
	public bool gameOver;
	float timer;

	public GameObject button; //кнопка Replay


	void Start()
	{
		button = GameObject.FindWithTag ("retryBtn");
		button.gameObject.SetActive (false);
		gameOver = false;
		timer = 3;	
	}

	// непанятная хуня(функция) которая позволяет вызывать GameControll в другом классe. не трогать если не хочешь получить пистов от самого себя в будущем
	void Awake () {
		if( instance == null )
		{
			instance = this;
		}else if( instance != this )
		{
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( gameOver == true)
		{
			button.gameObject.SetActive (true);
		}		
	}

	public void CharacterDied()
	{
		//gameOverText.SetActive(true);
		gameOver = true;
	}


	IEnumerator Deploy()
	{
  	yield return new WaitForSeconds(1F);
	}
}
