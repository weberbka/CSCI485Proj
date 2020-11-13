﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
