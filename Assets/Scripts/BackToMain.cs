﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMain : MonoBehaviour {

	void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(() => LoadGame());
	}

	void LoadGame()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
