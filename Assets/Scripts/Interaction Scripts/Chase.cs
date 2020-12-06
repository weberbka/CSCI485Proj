using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chase : MonoBehaviour
{
    public const float SPEED = 1f;
	private GameObject[] nodes;
	private int startNode = 0;
	private float timeout = 0;
	private Animator animator;
	private GameObject player;
	private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        nodes = GameObject.FindGameObjectsWithTag("Pathnode");
		animator = GetComponent<Animator>();
		player = GameObject.Find("Player");
		sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = this.transform.position;
		Vector2 detectCenter = this.transform.position;
		detectCenter.x += sprite.bounds.size.x/4.6f;
		detectCenter.y -= sprite.bounds.size.y/1.3f;
		if(Vector2.Distance(player.transform.position, detectCenter) < 4.5){
			animator.SetBool("Walking", true);
			if(detectCenter.x < player.transform.position.x) position.x += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2) * Time.deltaTime;
			else position.x -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2) * Time.deltaTime;
			if(detectCenter.y < player.transform.position.y) position.y += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2) * Time.deltaTime;
			else position.y -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2) * Time.deltaTime;
			this.transform.position = position;
		}else{
			if(Vector2.Distance(nodes[startNode].transform.position, position) > 1){
				if(timeout <= 0){
					animator.SetBool("Walking", true);
					if(position.x < nodes[startNode].transform.position.x) position.x += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2) * Time.deltaTime;
					else position.x -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2) * Time.deltaTime;
					if(position.y < nodes[startNode].transform.position.y) position.y += (float) Math.Sqrt(Math.Pow(SPEED, 2)/2) * Time.deltaTime;
					else position.y -= (float) Math.Sqrt(Math.Pow(SPEED, 2)/2) * Time.deltaTime;
					this.transform.position = position;
				}else{
					timeout -= Time.deltaTime;
					animator.SetBool("Walking", false);
				}
			}else{
				timeout = 5;
				startNode = (int) UnityEngine.Random.Range(0.0f, (float) (nodes.Length));
			}
		}
    }
}
