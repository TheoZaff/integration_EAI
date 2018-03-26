using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.Eai;

public class getDialogue : MonoBehaviour {

	public ArticyRef myRef;
	public string toPrint;
	public ArticyObject from;


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
			from = test.Speaker;

			Debug.Log (toPrint);
			Debug.Log (from);


		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
