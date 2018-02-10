using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
  public Tile tile;
  public Tile tile2;
  public Camera camera;

  private Tile[,] tiles;
  public int width {
    get;
    private set;
  }
  public int height {
    get;
    private set;
  }

	// Use this for initialization
	void Awake () {
    width = 10;
    height = 5;
    tiles = new Tile[width, height];
    for (int i = 0; i < width; i++) {
      for (int j = 0; j < height; j++) {
          tiles[i, j] = GameObject.Instantiate<Tile>((i + j) % 2 == 0 ? tile : tile2, new Vector3(i, j, 0), this.transform.rotation);
        }
    }
    camera.transform.position = new Vector3(width / 2.0f, height / 2.0f, -10);
	}

  public Tile GetTile(Vector3 position) {
    return tiles[(int)position.x, (int)position.y];
  }
	
	// Update is called once per frame
	void Update () {
		
	}
}
