using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
	public Building building;
	public Map map;

	public Player player {
		get { return GetComponent<Player> (); }
	}
	// Use this for initialization
	void Start ()
	{


	}

	// Update is called once per frame
	void Update ()
	{
		if (player.ID == 0) {
			if (Input.GetKeyDown (KeyCode.E)) {
				player.BuildBuilding (building, map);
			} else if (Input.GetKeyDown (KeyCode.W)) {
				if (transform.position.y < map.height - 1) {
					transform.position += Vector3.up;
				}
			} else if (Input.GetKeyDown (KeyCode.S)) {
				if (transform.position.y > 0) {
					transform.position += Vector3.down;
				}
			} else if (Input.GetKeyDown (KeyCode.A)) {
				if (transform.position.x > 0) {
					transform.position += Vector3.left;
				}
			} else if (Input.GetKeyDown (KeyCode.D)) {
				if (transform.position.x < map.width - 1) {
					transform.position += Vector3.right;
				}
			}
		}
		else {
			if (Input.GetKeyDown (KeyCode.Return)) {
				player.BuildBuilding (building, map);
			} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
				if (transform.position.y < map.height - 1) {
					transform.position += Vector3.up;
				}
			} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				if (transform.position.y > 0) {
					transform.position += Vector3.down;
				}
			} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				if (transform.position.x > 0) {
					transform.position += Vector3.left;
				}
			} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				if (transform.position.x < map.width - 1) {
					transform.position += Vector3.right;
				}
			}
		}
	}
}
