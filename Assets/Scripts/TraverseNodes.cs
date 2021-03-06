﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TraverseNodes : MonoBehaviour
{
	const float SPEED = 1f;
	public GameObject[] nodes;
	public int startNode = 0;
	public float timeout = 0;
	private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        nodes = GameObject.FindGameObjectsWithTag("Pathnode");
		animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = this.transform.position;
		if(Vector2.Distance(nodes[startNode].transform.position, position) > 1){
			//float step = SPEED * Time.deltaTime;
			//transform.position = Vector3.MoveTowards(transform.position, nodes[startNode].transform.position, step);
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
