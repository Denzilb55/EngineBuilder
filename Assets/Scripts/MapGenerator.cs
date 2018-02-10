using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
  public GameObject tile;
  public GameObject tile2;
  public Camera camera;

	// Use this for initialization
	void Start () {
    for (int i = 0; i < 10; i++) {
      for (int j = 0; j < 5; j++) {
          GameObject.Instantiate((i + j) % 2 == 0 ? tile : tile2, new Vector3(i, j, 0), this.transform.rotation);
        }      
    }
    camera.transform.position = new Vector3(5, 2.5f, -10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
