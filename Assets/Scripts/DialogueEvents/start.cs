using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public Button beg, ex, title;
	
    void Start()
    {
        if(beg != null) beg.onClick.AddListener(begin);
        ex.onClick.AddListener(end);
		title.onClick.AddListener(titl);
    }

    void begin()
    {
		SceneManager.LoadScene("City", LoadSceneMode.Single);
    }
	
	void end()
    {
		Application.Quit();
    }
	
	void titl(){
		SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
	}
}
