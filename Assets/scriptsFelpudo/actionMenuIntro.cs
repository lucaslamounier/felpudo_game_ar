using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionMenuIntro : MonoBehaviour {

	public Texture2D texturaFundo;
	public Texture2D texturaLogo;
	public Texture2D texturaFelpudo;

	private float larguraLogo = 200;
	private float alturaLogo = 120;

	private float larguraFelpudo = 280;
	private float alturaFelpudo = 250;

	private float larguraBotao = 160;
	private float alturaBotao = 40;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), texturaFundo, ScaleMode.StretchToFill);
		GUI.DrawTexture (new Rect (Screen.width - larguraLogo - 40, 40, larguraLogo, alturaLogo), texturaLogo, ScaleMode.StretchToFill);
		GUI.DrawTexture (new Rect (40, Screen.height/2 - alturaFelpudo/2, larguraFelpudo, alturaFelpudo), texturaFelpudo, ScaleMode.StretchToFill);

		if(GUI.Button(new Rect(Screen.width/2-larguraBotao/2,Screen.height/2 + alturaBotao - 30, larguraBotao, alturaBotao), "Jogar COM Câmera")){
			Application.LoadLevel("cenaFelpudoAR");
		}



		if(GUI.Button(new Rect(Screen.width/2-larguraBotao/2,Screen.height/2 + alturaBotao + 30, larguraBotao, alturaBotao), "Jogar SEM Câmera")){
			Application.LoadLevel("cenaFelpudo");
		}
	}


}
