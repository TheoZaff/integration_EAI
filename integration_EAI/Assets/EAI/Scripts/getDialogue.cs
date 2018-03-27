using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.Eai;

public class getDialogue : MonoBehaviour {

	public ArticyRef myRef;
	public string toPrint;
	public ArticyObject speaker;
	public static getDialogue Instance;


	// Use this for initialization
	void Start () {

		if (myRef.HasReference) {
			var obj = myRef.GetObject ();
			//Debug.Log (obj);

			DialogueFragment test = ArticyDatabase.GetObject<DialogueFragment> (obj.TechnicalName);
			//Debug.Log (test);
			//On peut recuperer les proprietes du DialogueFragment avec nomdufragment.propriete
			//Debug.Log(test.Text);
			//Debug.Log (test.Speaker);

			toPrint = test.Text;
			speaker = test.Speaker;
			Debug.Log (speaker);
			//Debug.Log (toPrint);
			//Debug.Log (speaker);


		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void awake(){
		Instance = this;
	}
}
