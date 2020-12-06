using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceBoard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.food.ToString() + " LBS";
	   transform.GetChild(1).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.weapons.ToString() + " LBS";
	   transform.GetChild(2).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.medicine.ToString() + " LBS";
	   transform.GetChild(3).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.wood.ToString() + " LBS";
	   transform.GetChild(4).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.iron.ToString() + " LBS";
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonUp(0)){
			RaycastHit2D hit = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0);
			if (hit && hit.collider.gameObject.name == "Resource Board"){
				Debug.Log("CHECK");
				ResourceCollector.food += PlayerData.food;
				PlayerData.food = 0;
				ResourceCollector.medicine += PlayerData.medicine;
				PlayerData.medicine = 0;
				ResourceCollector.weapons += PlayerData.weapons;
				PlayerData.weapons = 0;
				ResourceCollector.wood += PlayerData.wood;
				PlayerData.wood = 0;
				ResourceCollector.iron += PlayerData.iron;
				PlayerData.iron = 0;
				transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.food.ToString() + " LBS";
				transform.GetChild(1).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.weapons.ToString() + " LBS";
				transform.GetChild(2).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.medicine.ToString() + " LBS";
				transform.GetChild(3).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.wood.ToString() + " LBS";
				transform.GetChild(4).gameObject.GetComponent<TMP_Text>().text = ResourceCollector.iron.ToString() + " LBS";
			}
		}
    }
}
