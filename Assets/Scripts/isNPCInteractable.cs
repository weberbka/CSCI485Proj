using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isNPCInteractable : MonoBehaviour
{
	public GameObject player;
	public GameObject quest;
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 position = this.transform.position;
		position.y -= (float) (GetComponent<SpriteRenderer>().bounds.size.y*0.85);
        if(Vector3.Distance(player.transform.position, position) < 2) quest.transform.gameObject.SetActive(true);
		else quest.transform.gameObject.SetActive(false);
    }
}
