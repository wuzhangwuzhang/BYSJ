﻿using UnityEngine;
using System.Collections;

public class gameControllor : MonoBehaviour 
{
  
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
            Application.LoadLevel("Three");
		}
		if(Input.GetKey(KeyCode.Home))
		{
			Application.Quit();
		}
	}
}