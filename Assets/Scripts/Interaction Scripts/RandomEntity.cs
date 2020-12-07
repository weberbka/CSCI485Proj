using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomEntity : MonoBehaviour
{
	public Sprite corpse;
	public float detectOffsetY = 0.85f;
	public float detectOffsetX = 1.6f;
	public float range = 2.4f;
	//[TextArea(15,20)]
	//public string text;
	private string type;
	private GameObject player;
	private bool open = false;
	
    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.Find("Player");
		float rollType = Random.Range(1.00f, 100.9999f);
        if(rollType >= 0){
			this.GetComponent<SpriteRenderer>().sprite = corpse;
			type = "corpse";
		}else if(rollType >= 1){
			//nothing
		}
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
					bool isBattle = false;
					if(type == "corpse"){
						float roll = Random.Range(1.00f, 100.9999f);
						if(roll > 90){
							InteractionTextPro.text = "A dead man lays on the ground. Blood still pours out of him. Whatever caused his terrible misfortune must still be nearby." + 
							" You search his pockets and find a knife (2d4).";
							PlayerData.lastWeapon = PlayerData.weapon;
							PlayerData.weapon = new PlayerData.Weapon{name = "Knife", typeDice = 4, numDice = 2};
						}else if(roll > 70){
							InteractionTextPro.text = "A seemingly dead man lays on the ground then stirs. \"It's too late for me... please... take this...\" He gives you a pack of beef jerky. (food 0.5)";
							PlayerData.food += 0.5f;
						}else if(roll > 50){
							InteractionTextPro.text = "A dead man lays on the ground. He is covered in blood. You search him and find 2 twinkies in his pockets." + 
							" Whatever killed him must not of liked twinkies (food 0.3).";
							PlayerData.food += 0.3f;
						}else{
							isBattle = true;
							InteractionTextPro.text = "A dead man lays on the ground. He is covered in blood. Suddenly he stirs and grabs your leg.";
							Time.timeScale = 0.00f;
							SceneManager.LoadScene("Battle", LoadSceneMode.Additive);
							PlayerData.killNullify = true;
							PlayerData.currentBattle = new PlayerData.Enemy{name = "Zombie", typeDice = 6, numDice = 1};
							player.transform.GetChild(0).gameObject.GetComponent<Camera>().enabled = false;
						}
					}
					open = true;
					if(!isBattle) SceneManager.LoadScene("Interaction", LoadSceneMode.Additive);
					else Destroy(this.gameObject);
					player.transform.GetChild(0).gameObject.GetComponent<Camera>().enabled = false;
				}else{
					SceneManager.UnloadSceneAsync("Interaction");
					player.transform.GetChild(0).gameObject.GetComponent<Camera>().enabled = true;
					Destroy(this.gameObject);
				}
			}
		}else{
			this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
			if(open){
				SceneManager.UnloadSceneAsync("Interaction");
				player.transform.GetChild(0).gameObject.GetComponent<Camera>().enabled = true;
				Destroy(this.gameObject);
			}
		}
    }
}
