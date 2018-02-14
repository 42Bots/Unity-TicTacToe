using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : GameElement {

	public int[] Board;
	public Player Player1;
	public Player Player2;
	public Player NextMove;
	public int[] Score;

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
		Board = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		Player1 = new Player (true, "X", 1);
		Player2 = new Player (true, "O", 4);
		NextMove = Player1;
		TotalMoves = 0;
	}
}
