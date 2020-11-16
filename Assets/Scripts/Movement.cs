using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
	public Animator anima;
	const float SPEED = 0.0085f;
	bool moveDown = false;
	bool moveLeft = false;
	bool moveUp = false;
	bool moveRight = false;
	
	Vector3 lastPosition;
	private bool collided = false;
	
	public string inventory = "Inventory: None";
	
	//private bool pause = false;
	
	public GameObject[] interactables;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	private void OnTriggerEnter2D(Collider2D collision){
        this.transform.position = lastPosition;
		collided = true;
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
		Vector3 position = this.transform.position;
		if(!collided) lastPosition = position;
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			/*if(pause){
				pause = false;
				SceneManager.LoadScene("EndScreen", LoadSceneMode.Additive);
			}else{
				pause = true;
				SceneManager.LoadScene("EndScreen", LoadSceneMode.Additive);
			}*/
		}
		if (Input.GetKeyUp(KeyCode.A))
		{
			anima.SetBool("left", false);
			moveLeft = false;
		}
		if (Input.GetKeyUp(KeyCode.D))
		{
			anima.SetBool("right", false);
			moveRight = false;
		}
		if (Input.GetKeyUp(KeyCode.W))
		{
			anima.SetBool("up", false);
			moveUp = false;
		}
		if (Input.GetKeyUp(KeyCode.S))
		{
			anima.SetBool("down", false);
			moveDown = false;
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			anima.SetBool("left", true);
			moveLeft = true;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			anima.SetBool("right", true);
			moveRight = true;
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			anima.SetBool("up", true);
			moveUp = true;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			anima.SetBool("down", true);
			moveDown = true;
		}
		if (moveLeft && moveUp)
		{
			position.x -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			position.y += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			this.transform.position = position;
			//Camera.current.transform.Translate(new Vector3(-SPEED, SPEED, 0.0f));
		}
		else if (moveRight && moveDown)
		{
			position.x += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			position.y -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			this.transform.position = position;
			//Camera.current.transform.Translate(new Vector3(SPEED, -SPEED, 0.0f));
		}
		else if (moveUp && moveRight)
		{
			position.x += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			position.y += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			this.transform.position = position;
			//Camera.current.transform.Translate(new Vector3(SPEED, SPEED, 0.0f));
		}
		else if (moveDown && moveLeft)
		{
			position.x -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			position.y -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2);
			this.transform.position = position;
			//Camera.current.transform.Translate(new Vector3(-SPEED, -SPEED, 0.0f));
		}
        else if (moveLeft)
		{
			position.x -= SPEED;
			this.transform.position = position;
			//Camera.current.transform.Translate(new Vector3(-SPEED, 0.0f, 0.0f));
		}
		else if (moveRight)
		{
			position.x += SPEED;
			this.transform.position = position;
			//Camera.current.transform.Translate(new Vector3(SPEED, 0.0f, 0.0f));
		}
		else if (moveUp)
		{
			position.y += SPEED;
			this.transform.position = position;
			//Camera.current.transform.Translate(new Vector3(0.0f, SPEED, 0.0f));
		}
		else if (moveDown)
		{
			position.y -= SPEED;
			this.transform.position = position;
			//Camera.current.transform.Translate(new Vector3(0.0f, -SPEED, 0.0f));
		}
    }
}
