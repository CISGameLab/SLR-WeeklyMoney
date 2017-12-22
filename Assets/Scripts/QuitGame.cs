﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Button>().onClick.AddListener (() => ExitGame ());
	}
	
	// Update is called once per frame
	void ExitGame () 
	{
		Application.Quit ();
	}
}
