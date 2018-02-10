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

	public Color color;

	private List<Building> buildings;

	// Use this for initialization
	void Start () {
		credits = 10;
		buildings = new List<Building>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BuildBuilding(Building building, Map map) {
		if (credits >= 8) {
			Building b = GameObject.Instantiate(building, transform.position, transform.rotation);
			b.GetComponent<SpriteRenderer>().color = color;
			buildings.Add(b);
			credits -= 8;
		}
	}

	public void GetIncome() {
		credits += 2;
		foreach (Building building in buildings) {
			credits += 1;
		}
	}
}
