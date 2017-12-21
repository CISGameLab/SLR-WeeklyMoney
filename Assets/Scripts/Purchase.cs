using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purchase : MonoBehaviour {

	public Balance balance;
	public ClickObject cObject;
	public FoodPoints fPoints;
	public MoveAhead moveAhead;

	void Start () 
	{
		this.GetComponent<Button>().onClick.AddListener (() => UpdateBalance ());
	}

	void UpdateBalance () 
	{
		balance.SetBalance (cObject.cost);
		fPoints.SetFoodPoints (cObject.fPoints);
	}
}
