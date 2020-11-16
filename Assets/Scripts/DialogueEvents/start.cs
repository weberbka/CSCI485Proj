using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public Button beg, ex;
	
    void Start()
    {
        beg.onClick.AddListener(begin);
        ex.onClick.AddListener(end);
    }

    void begin()
    {
		SceneManager.LoadScene("City", LoadSceneMode.Single);
		SceneManager.UnloadSceneAsync("StartMenu");
    }
	
	void end()
    {
		Application.Quit();
    }
}
