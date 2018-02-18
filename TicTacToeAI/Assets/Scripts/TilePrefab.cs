using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePrefab : MonoBehaviour {

	public Sprite oSprite;
	public Sprite xSprite;
	public Sprite blankSprite;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer>();
		sr.sprite = oSprite;
	}

	public void onMouseDown() {
		Debug.Log ("Mouse click!");
	}
}
