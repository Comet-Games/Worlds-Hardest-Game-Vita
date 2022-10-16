using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton("Circle") || Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
		if(Input.GetButton("Cross") || Input.GetKey(KeyCode.Return))
		{
			SceneManager.LoadScene(1);
		}

    }
}
