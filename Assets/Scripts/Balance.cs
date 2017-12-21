using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balance : MonoBehaviour {

	public int currBalance;
	public int minBalance;
	public int itemBalance;

	void Start () 
	{
		currBalance = 200;
		this.GetComponent<Text>().text = "Balance: $" + currBalance;
	}

	void Update ()
	{
		if (itemBalance > 0) {
			currBalance = currBalance - itemBalance;
		}
	}

	public void SetBalance (int cost)
	{
		currBalance -= cost;
		this.GetComponent<Text> ().text = "Balance: $" + currBalance;
	}
}
