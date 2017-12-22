using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Purchase : MonoBehaviour {

	public Balance balance;
	public ClickObject cObject;
	public FoodPoints fPoints;
	public MoveAhead moveAhead;
	public new AudioSource audio;

	void Start () 
	{
		this.GetComponent<Button>().onClick.AddListener (() => UpdateBalance ());
	}

	void UpdateBalance () 
	{
		balance.SetBalance (cObject.cost);
		fPoints.SetFoodPoints (cObject.fPoints);
		audio.Play ();
		if (balance.currBalance < -50) 
		{
			SceneManager.LoadScene ("EndGame");
		}
	}
}
