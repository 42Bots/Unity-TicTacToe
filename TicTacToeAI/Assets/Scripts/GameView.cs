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

	private GameObject[] tiles;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void InitializeBoard(int[] board){
		tiles = new GameObject[board.Length];
		for (int tile = 0; tile < board.Length; tile++) {
			float tileX = ((tile % 3) - 1.0f) * spacing;
			float tileY = -((tile / 3) - 1.0f) * spacing; // first tile top left

			tiles [tile] = Instantiate (TilePrefab, new Vector2 (tileX, tileY), Quaternion.identity, this.transform);
			tiles [tile].name = ("Tile-" + tile);
			tiles [tile].GetComponent<MyTile> ().id = tile;

//			if (board [tile] == app.model.Player1.Value) {
//				tiles [tile].GetComponentInChildren<SpriteRenderer> ().sprite = app.model.Player1.Sign;
//				tiles [tile].GetComponent<MyTile> ().value = app.model.Player1.Value;
//			} 
//
//			else if (board [tile] == app.model.Player2.Value) {
//				tiles [tile].GetComponentInChildren<SpriteRenderer> ().sprite = app.model.Player2.Sign;
//				tiles [tile].GetComponent<MyTile> ().value = app.model.Player1.Value;
//			} 
//
//			else {
//				tiles [tile].GetComponentInChildren<SpriteRenderer> ().sprite = blankSprite;
//				tiles [tile].GetComponent<MyTile> ().value = 0;
//			}
		}

		DrawBoard (board);
	}

	public void DrawBoard(int[] board) {
		//GameObject myCanvas = Instantiate (CanvasPrefab, new Vector2 (0, 0), Quaternion.identity, this.transform);
		//the Canvas needs to have the render mode in world space to ove it as a regular obect

		for (int tile = 0; tile < board.Length; tile++) {
			if (board [tile] == app.model.Player1.Value) {
				tiles [tile].GetComponentInChildren<SpriteRenderer> ().sprite = app.model.Player1.Sign;
				tiles [tile].GetComponent<MyTile> ().value = app.model.Player1.Value;
			} 

			else if (board [tile] == app.model.Player2.Value) {
				tiles [tile].GetComponentInChildren<SpriteRenderer> ().sprite = app.model.Player2.Sign;
				tiles [tile].GetComponent<MyTile> ().value = app.model.Player1.Value;
			} 

			else {
				tiles [tile].GetComponentInChildren<SpriteRenderer> ().sprite = blankSprite;
				tiles [tile].GetComponent<MyTile> ().value = 0;
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
