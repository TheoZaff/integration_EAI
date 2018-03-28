using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.Eai;
using UnityEngine.UI;

public class displayCard : MonoBehaviour {

	public getDialogue myDialogue;
	//private ArticyObject mySpeaker;
	public Text Text;
	//public ArticyObject spk;
	//public string txt;

	void awake(){
		Text = GetComponent<Text> ();
		//Debug.Log (spk.ToString());
		//Debug.Log(txt);

	}

	// Update is called once per frame
	void Update () {
		ArticyObject spk = myDialogue.GetComponent<getDialogue>().speaker;
		string txt = myDialogue.GetComponent<getDialogue> ().toPrint;

		string thisSpeaker = spk.ToString ();
		string a = "(Articy.Eai.ASS)";

		Debug.Log (thisSpeaker);
		Debug.Log (a);

		if (thisSpeaker.Contains(a)){
			//Debug.Log ("toto");
			//mytext.text = ""+txt;
			print (txt);
			Text.text = txt;
		}else{
			Debug.Log ("tata");
		}

	}
}