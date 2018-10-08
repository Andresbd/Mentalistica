using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static bool passed, save;
	private GameManager GM;
	
	void Start () {
        
		//Check if a Game Manager exists
		if (GM == null)
		{
			DontDestroyOnLoad(gameObject);
			GM = this;
		}else if (GM != this)
		{
			Destroy(gameObject);
		}
	}

	private void Update()
	{
		if (passed)
		{
		}

		if (save)
		{
		}
	}
}
