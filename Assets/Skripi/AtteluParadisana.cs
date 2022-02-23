using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject pieauguso;
	public GameObject bernu;
	public GameObject attelaTuretajs;
	public Sprite[] atteluMasivs;
	public GameObject slaideris;



	public void PieaugusoAttelosana(bool vertiba){
		pieauguso.SetActive (vertiba);
	}
	public void BernuAttelosana(bool vertiba){
		bernu.SetActive (vertiba);
	}
		
	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attelaTuretajs.GetComponent<Image>().sprite = atteluMasivs [0];
		else if (skaitlis == 1)
			attelaTuretajs.GetComponent<Image>().sprite = atteluMasivs [1];
	}

	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1F * pasreizejaVertiba, 1F * pasreizejaVertiba);
	}
}