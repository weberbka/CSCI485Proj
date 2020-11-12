using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
	public Animator anima;
	const float SPEED = 0.0085f;
	bool moveDown = false;
	bool moveLeft = false;
	bool moveUp = false;
	bool moveRight = false;
	
	public GameObject[] interactables;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//INTERACTION
		if (Input.GetKeyUp(KeyCode.Space))
		{
			interactables = GameObject.FindGameObjectsWithTag("Interactable");
			foreach (GameObject I in interactables)
			{
				if(I.GetComponent<NPCInteraction>().active) I.GetComponent<NPCInteraction>().dialoguePart++;
			}
		}
		
		//MOVEMENT
		if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
			anima.SetBool("left", false);
			moveLeft = false;
		}
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			anima.SetBool("right", false);
			moveRight = false;
		}
		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			anima.SetBool("up", false);
			moveUp = false;
		}
		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			anima.SetBool("down", false);
			moveDown = false;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			anima.SetBool("left", true);
			moveLeft = true;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			anima.SetBool("right", true);
			moveRight = true;
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			anima.SetBool("up", true);
			moveUp = true;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			anima.SetBool("down", true);
			moveDown = true;
		}
		if (moveLeft && moveUp)
		{
			Vector3 position = this.transform.position;
			position.x -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			position.y += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			this.transform.position = position;
		}
		else if (moveRight && moveDown)
		{
			Vector3 position = this.transform.position;
			position.x += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			position.y -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			this.transform.position = position;
		}
		else if (moveUp && moveRight)
		{
			Vector3 position = this.transform.position;
			position.x += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			position.y += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			this.transform.position = position;
		}
		else if (moveDown && moveLeft)
		{
			Vector3 position = this.transform.position;
			position.x -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			position.y -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			this.transform.position = position;
		}
        else if (moveLeft)
		{
			Vector3 position = this.transform.position;
			position.x -= SPEED;
			this.transform.position = position;
		}
		else if (moveRight)
		{
			Vector3 position = this.transform.position;
			position.x += SPEED;
			this.transform.position = position;
		}
		else if (moveUp)
		{
			Vector3 position = this.transform.position;
			position.y += SPEED;
			this.transform.position = position;
		}
		else if (moveDown)
		{
			Vector3 position = this.transform.position;
			position.y -= SPEED;
			this.transform.position = position;
		}
    }
}
