using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.Eai;
using UnityEngine.UI;

public class displayBulle : MonoBehaviour {

	public getDialogue myDialogue;
	//private ArticyObject mySpeaker;
	public Text myText;

	// Use this for initialization
	void Start () {
		//recuperer from du getDialogue

		ArticyObject spk = myDialogue.GetComponent<getDialogue>().speaker;
		string txt = myDialogue.GetComponent<getDialogue> ().toPrint;
		//Debug.Log (spk.ToString());
		//Debug.Log(txt);

		string thisSpeaker = spk.ToString ();
		string a = "(Articy.Eai.ModelTemplate_03)";

		Debug.Log (thisSpeaker);
		Debug.Log (a);

		if (thisSpeaker.Contains(a)){
			//Debug.Log ("toto");
			//mytext.text = ""+txt;
			print (txt);
		}else{
			Debug.Log ("tata");
			}

	}

	public void startDialogue(){

		ArticyObject spk = myDialogue.GetComponent<getDialogue>().speaker;
		string txt = myDialogue.GetComponent<getDialogue> ().toPrint;
		//Debug.Log (spk.ToString());
		//Debug.Log(txt);

		string thisSpeaker = spk.ToString ();
		string a = "(Articy.Eai.ModelTemplate_03)";

		if (thisSpeaker.Contains(a)){
			//Debug.Log ("toto");
			//mytext.text = ""+txt;
			print (txt);
			myText.text = txt;
		}else{
			Debug.Log ("tata");
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
