﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	public Player playerTemplate;	
	public Text[] playerTexts;
	public Color[] playerColors;

	private int numPlayers;
	private Map map;

	private List<Player> players;

	private int turnTicks;
	private int turnTicksLeft;

    // Use this for initialization
    void Start ()
    {
        numPlayers = 2;
        map = GetComponent<Map> ();
        players = new List<Player> ();
        for (int i = 0; i < numPlayers; i++) {
            Player player = GameObject.Instantiate<Player> (playerTemplate);
            player.color = playerColors [i];
            players.Add (player);
            player.cursor.map = map;
            player.transform.position = i == 0 ? new Vector3 (0, 0, -1) : new Vector3 (map.width - 1, 0, -1);
            player.cursor.GetComponent<SpriteRenderer> ().color = player.color;
            playerTexts [i].color = player.color;
        }

        turnTicks = 5;
        turnTicksLeft = turnTicks;
        InvokeRepeating ("Tick", 1, 1);
    }
	
    // Update is called once per frame
    void Update ()
    {
        for (int i = 0; i < numPlayers; i++) {
            playerTexts [i].text = players [i].credits.ToString ();
        }
    }

    void Tick ()
    {
        turnTicksLeft -= 1;
        if (turnTicksLeft == 0) {
            turnTicksLeft = turnTicks;
            foreach (Player player in players) {
                player.GetIncome ();
            }
        }
    }
}
