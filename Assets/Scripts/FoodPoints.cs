using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodPoints : MonoBehaviour {

	public int currFoodPoints;
	public int itemFoodPoints;

	void Start () 
	{
		currFoodPoints = 0;
		this.GetComponent<Text>().text = "Food Points: " + currFoodPoints;
	}

	void Update () 
	{

	}

	public void SetFoodPoints (int fPoints)
	{
		currFoodPoints += fPoints;
		this.GetComponent<Text>().text = "Food Points: " + currFoodPoints;
	}
}
