using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResourceCollector : MonoBehaviour
{
	public GameObject player;
	private bool open = false;
	
	public int food = 0;
	public int weapons = 0;
	public int medicine = 0;
	public int wood = 0;
	public int iron = 0;
	
	
    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.Find("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
		position.y -= (float) (GetComponent<SpriteRenderer>().bounds.size.y*0.5);
		if(Vector3.Distance(player.transform.position, position) < 2){
			this.GetComponent<TraverseNodes>().timeout = 0.1f;
			this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
			if(player.GetComponent<Movement>().interactSignal){
				if(!open){
					open = true;
					SceneManager.LoadScene("ResourceMenu", LoadSceneMode.Additive);
				}else{
					open = false;
					SceneManager.UnloadSceneAsync("ResourceMenu");
				}
			}
		}else{
			this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
			if(open){
				open = false;
				SceneManager.UnloadSceneAsync("ResourceMenu");
			}
		}
    }
}
