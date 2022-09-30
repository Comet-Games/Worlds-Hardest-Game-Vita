using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour 
{
	[Header("Movement")]
	public float moveSpeed = 3f;
	public Transform Spawn;
	[Header("Deaths")]
	public int deaths = 0;
	public Text deathText;
	[Header("Level Stuff")]
	public int levelNum = 0;
	public GameObject[] levels;
	public Transform[] levelSpawns;
	public int coinsNeeded;
	public int currentCoins;

	[Header("Audio Stuff")]
	public AudioSource audioSource;
	public AudioClip deathSound;
	public AudioClip coinSound;

	public LevelManager levelManager;
	public Transform level2Spawn;

	Vector2 movement;
	// Use this for initialization
	void Start () {
		transform.position = Spawn.position;
		levelNum = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Controls();
		deathText.text = ("DEATHS: " + deaths);
	}

	void DeactivateLevels()
	{
		foreach(GameObject obj in levels)
		{
 			obj.SetActive(false);
 		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			audioSource.PlayOneShot(deathSound);
			deaths++;
			transform.position = Spawn.position;
			levelManager.ActivateCoins();
			currentCoins = 0;
		}

		if(other.gameObject.tag == "Coin")
		{
			audioSource.PlayOneShot(coinSound);
			currentCoins++;
			other.gameObject.SetActive(false);
		}

		if(other.gameObject.tag == "End" && currentCoins == coinsNeeded)
		{
			//Spawn.position = level2Spawn.position;
			levelNum++;
			currentCoins = 0;
			DeactivateLevels();
			Spawn.position = levelSpawns[levelNum].position;
			levels[levelNum].SetActive(true);
			transform.position = Spawn.position;
		}
	}

	private void Controls()
	{
		if (Input.GetButton ("Dup")) { // if D-Pad Up is pressed
			transform.position += Vector3.up * moveSpeed * Time.deltaTime;
		}
		if (Input.GetButton ("Ddown")) { // if D-Pad Down is pressed
			transform.position += Vector3.down * moveSpeed * Time.deltaTime;
		}
		if (Input.GetButton ("Dleft")) { // if D-Pad Left is pressed
			transform.position += Vector3.left * moveSpeed * Time.deltaTime;
		}
		if (Input.GetButton ("Dright")) { // if D-Pad Right is pressed
			transform.position += Vector3.right * moveSpeed * Time.deltaTime;
		}
	}

}
