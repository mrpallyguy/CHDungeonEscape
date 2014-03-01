using UnityEngine;
using System.Collections;

public class message : MonoBehaviour {
	
	void OnGUI () {
		GUI.Label (new Rect (300, 300, 400, 400), "Goodbye");
	}
	
}
