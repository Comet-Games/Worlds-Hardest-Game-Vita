using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {
	public Text levelText;
	public int levelNum = 1;
	public int levelAmount;
	public Player player;
	public GameObject[] coins;
	public Camera camera;
	public GameObject EndScreen;

	void Start()
	{
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
		if(levelNum == 1)
		{
			camera.orthographicSize = 5.0f;
			player.coinsNeeded = 0;
		}
		if(levelNum == 2)
		{
            camera.orthographicSize = 5.0f;
			player.coinsNeeded = 1;
		}
		if(levelNum == 3)
        {
            camera.orthographicSize = 5.0f;
			player.coinsNeeded = 1;
		}
		if(levelNum == 4)
		{
            camera.orthographicSize = 6.0f;
			player.coinsNeeded = 3;
		}
        if (levelNum == 5)
        {
            camera.orthographicSize = 6.0f;
            player.coinsNeeded = 0;
        }
        if (levelNum == 6)
        {
            camera.orthographicSize = 6.0f;
            player.coinsNeeded = 4;
        }
        if (levelNum == 7)
        {
            camera.orthographicSize = 5.0f;
            player.coinsNeeded = 3;
        }
    }
}
