using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionObjetos : MonoBehaviour {

	private bool cresce = false;
	private bool diminui = false;
	private Vector3 vetorEscalaObj = new Vector3(0.035f, 0.035f, 0.035f);

	// Use this for initialization
	void Start () {

		this.transform.localScale = new Vector3(0.01f,0.01f,0.01f);
		cresce = true;

	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position.z<-2.5){
			Destroy(this.gameObject);
		}  

		if((this.transform.localScale.x<1.0f)&&(cresce)){
			transform.localScale += vetorEscalaObj;
		}else{
			cresce=false;
		}
			
		if(transform.position.z<-1.75f){ 
			diminui = true;
		}

		if(diminui){
			if(this.transform.localScale.x>0.0f){
				transform.localScale -= vetorEscalaObj;
			}else{
				diminui=true;
			}
		}
	}
}
