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

	void Start()
	{
		levelAmount = player.levels.Length;
	}
	void Update()
	{
		UpdateCoins();
		levelNum = player.levelNum + 1;
		levelText.text = ("" + levelNum + "/" + levelAmount);
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
			player.coinsNeeded = 0;
		}
		if(levelNum == 2)
		{
			player.coinsNeeded = 1;
		}
		if(levelNum == 3)
		{
			player.coinsNeeded = 1;
		}
		if(levelNum == 4)
		{
			player.coinsNeeded = 3;
		}
	}
}
