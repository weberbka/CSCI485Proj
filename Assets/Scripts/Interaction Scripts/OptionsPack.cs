using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class OptionsPack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       this.gameObject.transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = PlayerData.food + " lbs";
	   this.gameObject.transform.GetChild(1).gameObject.GetComponent<TMP_Text>().text = PlayerData.medicine + " lbs";
	   this.gameObject.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().text = PlayerData.weapons + " lbs";
	   this.gameObject.transform.GetChild(3).gameObject.GetComponent<TMP_Text>().text = PlayerData.wood + " lbs";
	   this.gameObject.transform.GetChild(4).gameObject.GetComponent<TMP_Text>().text = PlayerData.iron + " lbs";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
