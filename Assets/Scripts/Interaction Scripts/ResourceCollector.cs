using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCollector : MonoBehaviour
{
	public GameObject player;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.Find("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
		position.y -= (float) (GetComponent<SpriteRenderer>().bounds.size.y*0.85);
		if(Vector3.Distance(player.transform.position, position) < 2){
			this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
		}else this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
}
