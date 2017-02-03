using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject Sol;

	// Use this for initialization
	void Start () {
		CreateLevel ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void CreateLevel(){
		float tailleSol = Sol.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;

		for (int i = 0; i < 10; i++) {
			for (int y = 0; y < 10; y++) {
				GameObject NouveauSol = Instantiate (Sol);
				NouveauSol.transform.position = new Vector3 (y,i, 0);
			}
		}
	}
}
