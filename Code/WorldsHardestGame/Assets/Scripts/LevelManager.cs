using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public Text levelText;
	public int levelNum = 1;
	public int currentLevel = 0;
	public int levelAmount;
	public Player player;
	public GameObject[] coins;
	public Camera camera;
	public GameObject EndScreen;

	public GameObject optionsMenu;

	void Start()
	{
		optionsMenu.SetActive(false);
		levelAmount = player.levels.Length;
	}
	void Update()
	{
		UpdateCoins();
		levelNum = player.levelNum + 1;
		levelText.text = ("" + levelNum + "/" + levelAmount);

		if(levelNum > levelAmount)
		{
			EndScreen.SetActive(true);
		}

		if(Input.GetButtonDown("Select") || (Input.GetButtonDown("Start")) && optionsMenu != true)
		{
			optionsMenu.SetActive(true);
			Time.timeScale = 0;

        }
        if (Input.GetButtonDown("Select") || (Input.GetButtonDown("Start")) && optionsMenu != false)
		{
            optionsMenu.SetActive(false);
			Time.timeScale = 1;
        }
		if(Input.GetButtonDown("Cross") && optionsMenu == true)
		{
            SceneManager.LoadScene(1);
        }

    }
    public void ActivateCoins()
	{
		foreach(GameObject obj in coins)
		{
 			obj.SetActive(true);
 		}
	}

	void UpdateCoins()
	{
		switch(levelNum)
		{
			case 1:
                camera.orthographicSize = 5.0f;
                player.coinsNeeded = 0;
				break;
            case 2:
                camera.orthographicSize = 5.0f;
                player.coinsNeeded = 1;
                break;
			case 3:
                camera.orthographicSize = 5.0f;
                player.coinsNeeded = 1;
				break;
			case 4:
                camera.orthographicSize = 6.0f;
                player.coinsNeeded = 3;
				break;
			case 5:
                camera.orthographicSize = 6.0f;
                player.coinsNeeded = 0;
				break;
			case 6:
                camera.orthographicSize = 6.0f;
                player.coinsNeeded = 4;
                break;
			case 7:
                camera.orthographicSize = 5.0f;
                player.coinsNeeded = 4;
                break;
			case 8:
                camera.orthographicSize = 5.0f;
                player.coinsNeeded = 3;
                break;
			case 9:
                camera.orthographicSize = 5.0f;
                player.coinsNeeded = 1;
                break;
        }
    }
}
