using System.IO;
using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	public static LevelManager instance;
	void Awake () {
		if( instance == null )
		{
			instance = this;
		}else if( instance != this )
		{
			Destroy(gameObject);
		}
	}


	public void LoadGame ()	{
		
		string levelName;
		TextAsset lastLevel = Resources.Load ("LastLevel") as TextAsset;
		levelName = lastLevel.text;
		Application.LoadLevel (levelName);
	
	}
}
