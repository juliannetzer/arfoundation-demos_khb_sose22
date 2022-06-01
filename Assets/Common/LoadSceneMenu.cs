﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;


public class LoadSceneMenu : MonoBehaviour
{
	public void ChangeScene (string SceneName){
		SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }
}