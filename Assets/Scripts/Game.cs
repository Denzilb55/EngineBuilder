using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public Player playerTemplate;
	private Map map;

	// Use this for initialization
	void Start () {
		map = GetComponent<Map>();
		Player player = GameObject.Instantiate<Player>(playerTemplate);
		player.cursor.map = map;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
