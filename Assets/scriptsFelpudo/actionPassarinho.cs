using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionPassarinho : MonoBehaviour {

	public GameObject objetoCamera;
	private actionCenaPrincipal scriptB;

	// Use this for initialization
	void Start () {
		scriptB = (actionCenaPrincipal)objetoCamera.GetComponent (typeof(actionCenaPrincipal));

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider outro)
	{
		if(outro.gameObject.tag == "CANO")
		{ 
			scriptB.fimDeJogo();
			print ("morreu");
			GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			GetComponent<Rigidbody>().AddForce (new Vector3(0,200,-200), ForceMode.Force);
		}
	}

	void OnTriggerExit(Collider outro)
	{
		if(outro.gameObject.tag == "VAO")
		{	
			print ("marcou ponto");
			scriptB.updateScore();
		}
	} 

}
