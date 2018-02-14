using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : GameElement {

	public float spacing = 1.2f;
	int boardSize;

	public GameObject XPrefab;
	public GameObject OPrefab;
	public GameObject BlankPrefab;
	//public GameObject CanvasPrefab;


	// Use this for initialization
	void Start () {
		boardSize = 9;
		GenerateGrid ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void GenerateGrid() {
		//GameObject myCanvas = Instantiate (CanvasPrefab, new Vector2 (0, 0), Quaternion.identity, this.transform);
		//the Canvas needs to have the render mode in world space to ove it as a regular obect

		for (int tile = 0; tile < boardSize; tile++) {
			float tileX = ((tile % 3) - 1.0f) * spacing;
			float tileY = ((tile / 3) - 1.0f) * spacing;

			GameObject myTile = Instantiate (BlankPrefab, new Vector2 (tileX, tileY), Quaternion.identity, this.transform);
			myTile.name = "Tile-" + tile;
		}
	}

	// To-Do:
	// Create a generic tile view with a scrpipt that will send an event when a tile is clicked
	// Also, the actual sprite should be changed, so we should only need one prefab
	// public Sprite mySprite;
	// this.GetComponent<SpriteRenderer>().sprite = mySprite;
	// or as per unity: https://docs.unity3d.com/ScriptReference/UI.Image-sprite.html
}
