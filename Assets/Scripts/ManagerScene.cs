﻿using UnityEngine;
using System.Collections;

public class ManagerScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadLevel(int number)
	{
		Application.LoadLevel (number);
	}
}
