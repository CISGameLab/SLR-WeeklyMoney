using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveAhead : MonoBehaviour {

	public Balance balance;
	public ClickObject cObject;
	public FoodPoints fPoints;
	public Text Balance;
	public Text Points;
	public int weekNumber;
	public int cost;
	public int point;
	public new AudioSource audio;

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
			audio.Play ();
			if (fPoints.currFoodPoints < -10) 
			{
				SceneManager.LoadScene ("EndGame");
			}
		}

		if (weekNumber % 4 == 0) 
		{
			if (balance.currBalance > 0) {
				balance.currBalance = 200;
			}
			if (balance.currBalance < 0) {
				balance.currBalance = balance.currBalance + 200;
			}
			if (balance.currBalance < -50) 
			{
				SceneManager.LoadScene ("EndGame");
			}

		}

		Balance.text = "Balance: $" + balance.currBalance;
		Points.text = "Food Points: " + fPoints.currFoodPoints;
	}
}
