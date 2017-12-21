using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAhead : MonoBehaviour {

	public Balance balance;
	public ClickObject cObject;
	public FoodPoints fPoints;
	public Text Balance;
	public Text Points;
	public int weekNumber;
	public int cost;
	public int point;

	void Start () 
	{
		this.GetComponent<Button>().onClick.AddListener(() => BuyGas());
		weekNumber = 1;
	}

	void BuyGas()
	{
		if (gameObject.name == "WeekSkip") {
			point = 10;
			cost = Random.Range (22, 33);
			balance.currBalance = balance.currBalance - cost;
			weekNumber++;
			fPoints.currFoodPoints = fPoints.currFoodPoints - point;
		}

		if (weekNumber % 4 == 0) {
			balance.currBalance = 200;
		}

		Balance.text = "Balance: " + balance.currBalance;
		Points.text = "Food Points: " + fPoints.currFoodPoints;
	}
}
