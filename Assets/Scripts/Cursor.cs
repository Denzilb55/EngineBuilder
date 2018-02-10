using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
  public Building building;

  // Use this for initialization
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.E)) {
      GameObject.Instantiate(building, transform.position, transform.rotation);
    }
    else if (Input.GetKeyDown(KeyCode.W)) {
      transform.position += Vector3.up;
    }
    else if (Input.GetKeyDown(KeyCode.S)) {
      transform.position += Vector3.down;
    }
    else if (Input.GetKeyDown(KeyCode.A)) {
      transform.position += Vector3.left;
    }
    else if (Input.GetKeyDown(KeyCode.D)) {
      transform.position += Vector3.right;
    }
  }
}
