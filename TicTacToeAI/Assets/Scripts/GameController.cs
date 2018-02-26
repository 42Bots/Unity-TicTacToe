using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : GameElement {

	private GameModel game;
	private GameView view;

	// Use this for initialization
	void Start () {
		game = app.model;
		view = app.view;

		view.InitializeBoard (game.Board);
	}

	public bool Move(int tile){
		bool vallidMove = false;

		if (game.Board[tile] == 0) {
			game.Board[tile] = game.NextMove.Value;
			UpdateNextMove ();
			game.TotalMoves++;
			view.DrawBoard (game.Board);
			checkBoard (game);
		}
		return vallidMove;
	}

	public void UpdateNextMove() {
		if (game.NextMove == game.Player1) {
			game.NextMove = game.Player2;
		}

		else if (game.NextMove == game.Player2) {
			game.NextMove = game.Player1;
		}
	}

	public int checkBoard(GameModel game) {
		int status = 0;

		for (int i = 0; i < game.Lines.Length; i++) {
			int sum = 0;

			for (int j = 0; j < game.Lines[i].Length; j++) {
				int tile = game.Lines[i][j];
				sum = sum + game.Board[tile];
			}

			Debug.Log ("Line: " + i + " Sum: " + sum);

			if (sum == (3 * game.Player1.Value)) {
				status = game.Player1.Value;
				Debug.Log ("Winner: " + game.Player1.Value);
				return status;
			} 

			if (sum == (3 * game.Player2.Value)) {
				status = game.Player2.Value;
				Debug.Log ("Winner: " + game.Player1.Value);
				return status;
			}
		}
			
		//check for draw
		if (game.TotalMoves == 9) {
			Debug.Log ("Game is a draw!");
			status = -1;
		}

		return status;
	}

	void OnEnable ()
	{
		EventManager.StartListnening ("MouseClick", HumanMove);
	}

	void OnDisable ()
	{
		EventManager.StopListening ("MouseClick", HumanMove);
	}

	void OnDestroy ()
	{
		EventManager.StopListening ("MouseClick", HumanMove);
	}

	// Handles the mouseclick event
	public void HumanMove(int tile) {
		//Debug.Log ("Detected MouseClick event on tile "+ tile);
		Move (tile);
	}
}
