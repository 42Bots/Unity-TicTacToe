using System.Collections;
using System.Collections.Generic;

public class Player {

	public bool Human = true;
	public string Sign = "X";
	public int Value = 1;

	public Player(bool human, string sign, int value) {
		Human = human;
		Sign = sign;
		Value = value;
	}

}
