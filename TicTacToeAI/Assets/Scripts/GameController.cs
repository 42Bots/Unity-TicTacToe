using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : GameElement {

	public GameModel game;

	// Use this for initialization
	void Start () {
		
	}

	public bool Move(int tile){
		bool vallidMove = false;

		if (game.Board[tile] == 0) {
			game.Board[tile] = game.NextMove.Value;
			UpdateNextMove ();
			game.TotalMoves++;
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
		return status;
	}
}
