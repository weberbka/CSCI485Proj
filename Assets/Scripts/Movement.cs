using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
	const float SPEED = 3f;
	
	private Rigidbody2D rb2d;
	private Animator animator;
	Vector2 movement;	
	
	private bool pause = false;
	
	public bool interactSignal = true;
	
	
    // Start is called before the first frame update
    void Start()
    {
         rb2d = GetComponent<Rigidbody2D>();
		 animator = GetComponent<Animator>();
		 if(!PlayerData.useUnityPosition) transform.position = PlayerData.playerPosition;
    }
	
    // Update is called once per frame
    void Update()
    {
		//MOVEMENT
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
		
		animator.SetFloat("Horizontal", movement.x);
		animator.SetFloat("Vertical", movement.y);
		animator.SetFloat("Speed", movement.sqrMagnitude);
		
		if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1){
			animator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
			animator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
		}
		
		//INTERACTION
		if (Input.GetKeyDown(KeyCode.Space))
		{
			interactSignal = true;
		}else interactSignal = false;
		
		//OPTIONS
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			if(pause){
				pause = false;
			}else{
				pause = true;
				SceneManager.LoadScene("OptionsMenu", LoadSceneMode.Additive);
			}
		}
    }
	
	void FixedUpdate(){
		rb2d.MovePosition(rb2d.position + movement * SPEED * Time.fixedDeltaTime);
	}
}
