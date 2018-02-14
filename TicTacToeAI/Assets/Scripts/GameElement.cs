using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameElement : MonoBehaviour {
	// Gives access to the application and all instances.
	public Application app { get { return GameObject.FindObjectOfType<Application>(); }}
}
