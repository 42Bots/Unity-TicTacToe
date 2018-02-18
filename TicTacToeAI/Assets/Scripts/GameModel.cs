//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : GameElement {

	public int[] Board;
	public Player Player1;
	public Player Player2;
	public Player NextMove;
	public int[] Score;
	public int P1 = 1;
	public int P2 = 4;

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

	public int TotalMoves;

	// Use this for initialization
	void Start () {

		Player1 = new Player (true, app.view.xSprite, P1);
		Player2 = new Player (true, app.view.oSprite, P2);

		Board = new int[] { P1, 0, P2, 0, 0, 0, P2, P1, 0 };
		NextMove = Player1;
		TotalMoves = 4;
	}
}
