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
		PlayerData.useUnityPosition = true;
		if(transformPlayer){
			PlayerData.playerPosition = transformTo;
			PlayerData.useUnityPosition = false;
		}
		SceneManager.LoadSceneAsync(sceneToLoad);
		
    }
}
