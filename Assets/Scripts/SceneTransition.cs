using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
	private GameObject player;
    public string sceneToLoad;
	public bool destroyPlayer = true;
	public Vector2 transformPlayer;
	
	void Start()
    {
		player = GameObject.Find("Player"); 
    }
	
    void OnTriggerEnter2D(Collider2D other)
    {
		SceneManager.LoadSceneAsync(sceneToLoad);
		if(!destroyPlayer){
			player.transform.position = transformPlayer;
			DontDestroyOnLoad(player);
		}
    }
}
