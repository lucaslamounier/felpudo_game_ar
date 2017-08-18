using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionPeninha : MonoBehaviour {

	private bool diminui;
	// Use this for initialization
	void Start () {
		Invoke ("DiminuiPeninha", 1); // 1 segundo apos criado chama a função.
	}
	
	// Update is called once per frame
	void Update () {

		if (diminui) {
			if (this.transform.localScale.x > 0.0f) {
				transform.localScale -= new Vector3 (0.01f, 0.01f, 0.01f);
			} else {
				Destroy (this.gameObject);
			}
		}
	}

	void DiminuiPeninha(){
		diminui = true;
	}
}
