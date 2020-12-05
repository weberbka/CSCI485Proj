using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceBoard : MonoBehaviour
{
	GameObject resourceCollector;
    // Start is called before the first frame update
    void Start()
    {
        resourceCollector = GameObject.Find("Resource_Collector");
    }

    // Update is called once per frame
    void Update()
    {
       this.gameObject.transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = resourceCollector.GetComponent<ResourceCollector>().food.ToString() + " LBS";
	   this.gameObject.transform.GetChild(1).gameObject.GetComponent<TMP_Text>().text = resourceCollector.GetComponent<ResourceCollector>().weapons.ToString() + " LBS";
	   this.gameObject.transform.GetChild(2).gameObject.GetComponent<TMP_Text>().text = resourceCollector.GetComponent<ResourceCollector>().medicine.ToString() + " LBS";
	   this.gameObject.transform.GetChild(3).gameObject.GetComponent<TMP_Text>().text = resourceCollector.GetComponent<ResourceCollector>().wood.ToString() + " LBS";
	   this.gameObject.transform.GetChild(4).gameObject.GetComponent<TMP_Text>().text = resourceCollector.GetComponent<ResourceCollector>().iron.ToString() + " LBS";
    }
}
