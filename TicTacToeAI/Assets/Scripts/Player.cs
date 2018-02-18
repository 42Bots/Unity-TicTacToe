using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

	public bool Human;
	public Sprite Sign;
	public int Value;

	public Player(bool human, Sprite sign, int value) {
		Human = human;
		Sign = sign;
		Value = value;
	}
}
