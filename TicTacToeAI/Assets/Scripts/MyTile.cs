using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTile : MonoBehaviour {

	void OnMouseDown() {
		Debug.Log (this.name + " was clicked!");
	}
}
