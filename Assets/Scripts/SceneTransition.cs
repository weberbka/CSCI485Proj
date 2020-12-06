using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
	public bool transformPlayer;
	public Vector2 transformTo;
	
	void Start()
    {
		
    }
	
    void OnTriggerEnter2D(Collider2D other)
    {
		if(transformPlayer) PlayerData.playerPosition = transformTo;
		SceneManager.LoadSceneAsync(sceneToLoad);
		
    }
}
