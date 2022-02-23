using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Uzglabas tekstu kurs panemts no input lauka
	public string teksts;
	public string teksts2;
	//Lauks no kura es to tekstu panemsu
	public GameObject ievadesLauks;
	public GameObject ievadesLauks2;
	//teksta objekts kur attelot mainiga Teksta saturu
	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		teksts2 = ievadesLauks2.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text>().text = "Sis ir " + teksts.ToUpper () + "! Vinam ir " + teksts2.ToUpper() +" gadi.";
	}
}
