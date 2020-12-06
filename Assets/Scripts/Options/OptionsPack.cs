using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class OptionsPack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = PlayerData.food + " lbs";
	   transform.GetChild(1).gameObject.GetComponent<TMP_Text>().text = PlayerData.medicine + " lbs";
	   transform.GetChild(2).gameObject.GetComponent<TMP_Text>().text = PlayerData.weapons + " lbs";
	   transform.GetChild(3).gameObject.GetComponent<TMP_Text>().text = PlayerData.wood + " lbs";
	   transform.GetChild(4).gameObject.GetComponent<TMP_Text>().text = PlayerData.iron + " lbs";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
