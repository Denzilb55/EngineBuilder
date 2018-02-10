using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int credits {
		get;
		private set;
	}

	public Cursor cursor {
		get {return GetComponent<Cursor>();}
	}

	// Use this for initialization
	void Start () {
		credits = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BuildBuilding(Building building, Map map) {
		if (credits >= 8) {
			GameObject.Instantiate(building, transform.position, transform.rotation);
			credits -= 8;
			Debug.Log(map.GetTile(transform.position));
		}
	}
}
