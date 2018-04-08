using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	



public class GameControll : MonoBehaviour {

	public static GameControll instance;
	public bool gameOver;


	public GameObject button; //кнопка Replay


	void Start()
	{
		
		gameOver = false;

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
			Application.LoadLevel ("gameover");
		}		
	}

	public void CharacterDied()
	{
		gameOver = true;
	}



}
