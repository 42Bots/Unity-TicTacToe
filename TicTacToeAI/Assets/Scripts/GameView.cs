using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : GameElement {

	public float spacing = 1.2f;
	int[] board;

	public Sprite oSprite;
	public Sprite xSprite;
	public Sprite blankSprite;
	public GameObject TilePrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void DrawBoard(int[] board) {
		//GameObject myCanvas = Instantiate (CanvasPrefab, new Vector2 (0, 0), Quaternion.identity, this.transform);
		//the Canvas needs to have the render mode in world space to ove it as a regular obect

		for (int tile = 0; tile < board.Length; tile++) {
			float tileX = ((tile % 3) - 1.0f) * spacing;
			float tileY = -((tile / 3) - 1.0f) * spacing; // first tile top left

			GameObject myTile = Instantiate (TilePrefab, new Vector2 (tileX, tileY), Quaternion.identity, this.transform);
			myTile.name = "Tile-" + tile;

			if (board [tile] == app.model.Player1.Value) {
				myTile.GetComponentInChildren<SpriteRenderer> ().sprite = app.model.Player1.Sign;
			} 

			else if (board [tile] == app.model.Player2.Value) {
				myTile.GetComponentInChildren<SpriteRenderer> ().sprite = app.model.Player2.Sign;
			} 

			else {
				myTile.GetComponentInChildren<SpriteRenderer> ().sprite = blankSprite;
			}
		}
	}
		
	// To-Do:
	// Create a generic tile view with a scrpipt that will send an event when a tile is clicked
	// Also, the actual sprite should be changed, so we should only need one prefab
	// public Sprite mySprite;
	// this.GetComponent<SpriteRenderer>().sprite = mySprite;
	// or as per unity: https://docs.unity3d.com/ScriptReference/UI.Image-sprite.html
}
