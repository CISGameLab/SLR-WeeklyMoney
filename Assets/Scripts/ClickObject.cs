using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour {
    
	public ShopObject shopObject;
	public Text Name;
	public Text Balance;
	public Text Points;
	public Text Description;
	public int cost;
	public int fPoints;
	public ShopObject currParentSO;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
					DisplayInfo(hit.transform.gameObject);
                }
            }
        }
    }

    public void DisplayInfo(GameObject go)
    {
		currParentSO  = GameObject.Find (go.transform.parent.name).GetComponent<ShopObject>();

		Name.text = "Name: " + currParentSO.itemName;
		Balance.text = "Cost: " + currParentSO.itemBalance;
		cost = currParentSO.itemBalance;
		Points.text = "Food Points: " + currParentSO.foodPoints;
		fPoints = currParentSO.foodPoints;
		Description.text = "Description: " + currParentSO.description;
    }
}
