//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : GameElement {

	internal int[] Board;
	internal Player Player1;
	internal Player Player2;
	internal Player NextMove;
	internal int TotalMoves;
	internal const int P1 = 1;
	internal const int P2 = (3 * P1 + 1); //this helps with calculating if a player won

	public int[][] Lines = new int[][]
	{
		new int[] {0,1,2},
		new int[] {3,4,5},
		new int[] {6,7,8},
		new int[] {0,3,6},
		new int[] {1,4,7},
		new int[] {2,5,8},
		new int[] {0,4,8},
		new int[] {2,4,6},
	};

	// Use this for initialization
	void Start () {

		Player1 = new Player (true, app.view.xSprite, P1);
		Player2 = new Player (true, app.view.oSprite, P2);

		Board = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		NextMove = Player1;
		TotalMoves = 0;
	}
}
