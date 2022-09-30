using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton ("Start") || Input.GetButton ("Cross")) { // if start or x is pressed
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
