using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Character : MonoBehaviour{

	float	Center_Screen_X;
	float	Center_Screen_Y;
	Vector2	StartVector2;
	Rigidbody2D	rbCharacter;
	bool	isCharacterUp ;
	bool	touchJump;
	bool	isDead;
	float distanceOfJump;
	float heightOfJump;
	float step;



	// Use this for initialization
	void Start () {
		Center_Screen_X = Screen.width;
		Center_Screen_Y = Screen.height;
		StartVector2 = transform.position;
		rbCharacter = GetComponent<Rigidbody2D>();
		distanceOfJump = heightOfJump = 1; // heightOfJump = distanceOfJump
		isCharacterUp = true;
		step = 0.09F;
		touchJump = false;
		isDead = false;
	}
	
	// Update is called once per frame
	void Update () {


		if( Input.touchCount > 0 && isDead == false)
		{
			foreach(Touch touch in Input.touches)
			{
				if( Center_Screen_Y/2 > touch.position.y	&&	Center_Screen_X/2 < touch.position.x && isCharacterUp) //move forvard
				{

					transform.position = Vector2.MoveTowards( (Vector2)transform.position, new Vector2( touch.position.x, 0), step );

				}
				else if( Center_Screen_Y/2 > touch.position.y &&  Center_Screen_X/2 > touch.position.x && isCharacterUp) //move back
				{

					transform.position = Vector2.MoveTowards( (Vector2)transform.position, new Vector2( -touch.position.y, 0), step );

				}
				else if( Center_Screen_Y/2 < touch.position.y	 &&	 isCharacterUp) //jump
				{	
					
					rbCharacter.AddForce( Vector2.up * 2F, ForceMode2D.Impulse );
					//rbCharacter.AddForce( Vector2.up * 5F, ForceMode2D.Impulse);
				}			
			}	
		}


	
	}



	//Проверка на местоположение для прыжка
	void OnCollisionExit2D()
	{
				isCharacterUp = false;	
	}



	void OnCollisionEnter2D( Collision2D c )
	{		

		isCharacterUp = true;	
		if(c.gameObject.name == "ice")
		{
			isDead = true;
			GameControll.instance.CharacterDied();
		}
	}
	


}
