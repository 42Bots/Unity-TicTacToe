using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTile : MonoBehaviour {

	public int value = 0;
	public int id = 0;

	void OnMouseDown() {
		//Debug.Log (this.name + " was clicked!");
		EventManager.TriggerEvent ("MouseClick", id);
	}
}
