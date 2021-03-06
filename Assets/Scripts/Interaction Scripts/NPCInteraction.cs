﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
	public GameObject player;
	public ArrayList dialogue = new ArrayList();
	private GameObject quest;
	public bool hasQuest = false;
	public int dialoguePart = 0;
	public bool active = false;
	
    // Start is called before the first frame update
    void Start()
    {
		//foreach (Transform child in this.transform) child.gameObject.SetActive(false);
		player = GameObject.Find("Player");
		this.gameObject.tag = "Interactable";
		//questScript.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
		// if(hasQuest){
			// Vector3 position = this.transform.position;
			// position.y -= (float) (GetComponent<SpriteRenderer>().bounds.size.y*0.85);
			// int count = 0;
			// active = false;
			// foreach (Transform child in transform){
				// child.gameObject.SetActive(false);
				// if(count == dialoguePart && Vector3.Distance(player.transform.position, position) < 2){
					// child.gameObject.SetActive(true);
					// active = true;
				// }
				// count++;
			// }
		// }
		if(hasQuest){
			Vector3 position = this.transform.position;
			position.y -= (float) (GetComponent<SpriteRenderer>().bounds.size.y*0.85);
			if(Vector3.Distance(player.transform.position, position) < 2){
				//questScript.enabled = true;
			}
		}
    }
}
