using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEntity : MonoBehaviour
{
	public Sprite corpse;
	private string type;
	
    // Start is called before the first frame update
    void Start()
    {
		float rollType = Random.Range(1.00f, 100.9999f);
        if(rollType >= 10){
			//Corpse
			this.GetComponent<SpriteRenderer>().sprite = corpse;
			type = "interact";
			//type = "chase";
		}else if(rollType >= 1){
			//nothing
			
		}
    }

    // Update is called once per frame
    void Update()
    {
        if(type == "interact"){
			
		}
    }
}
