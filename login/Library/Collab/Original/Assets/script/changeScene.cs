﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D other){
    	print("he");
    	if(other.CompareTag("Player")) {

    		SceneManager.LoadScene(1);
    	}
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
