using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeInteraction : MonoBehaviour
{
	private GameObject player;
	private bool open = false;
	public float detectOffsetY = 0.85f;
	public float detectOffsetX = 1.6f;
	public float range = 2.4f;
	[TextArea(15,20)]
	public string text;
	
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
		position.y -= (float) (GetComponent<SpriteRenderer>().bounds.size.y - detectOffsetY);
		position.x += (float) (GetComponent<SpriteRenderer>().bounds.size.x - detectOffsetX);
		if(Vector3.Distance(player.transform.position, position) < range){
			transform.GetChild(0).gameObject.SetActive(true);
			if(player.GetComponent<Movement>().interactSignal){
				if(!open){
					PlayerData.lastWeapon = PlayerData.weapon;
					PlayerData.weapon = new PlayerData.Weapon{name = "Cain", typeDice = 6, numDice = 1};
					open = true;
					InteractionTextPro.text = text;
					SceneManager.LoadScene("Interaction", LoadSceneMode.Additive);
					player.transform.GetChild(0).gameObject.GetComponent<Camera>().enabled = false;
				}else{
					open = false;
					SceneManager.UnloadSceneAsync("Interaction");
					player.transform.GetChild(0).gameObject.GetComponent<Camera>().enabled = true;
					GetComponent<TreeInteraction>().enabled = false;
				}
			}
		}else{
			this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
			if(open){
				open = false;
				SceneManager.UnloadSceneAsync("Interaction");
				player.transform.GetChild(0).gameObject.GetComponent<Camera>().enabled = true;
			}
		}
    }
}
