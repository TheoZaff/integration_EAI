using Articy.Unity;
using Articy.Unity.Interfaces;
using System.Collections.Generic;
using UnityEngine;

public class MyDialogueHandler : MonoBehaviour, IArticyFlowPlayerCallbacks
{
	// every pause we remember the very first branch, so we can continue the flow using it
	private Branch firstBranch;

	public void OnFlowPlayerPaused(IFlowObject aObject)
	{
		// we just print every text to the console

		//Au lieu de print dans la console, display le texte au bon endroit comme dans les scripts de display
		//Voir pour setActive() des bouttons en fonction du nombre de possibilités de réponses et display les textes de réponse sur ces boutons

		var textObject = aObject as IObjectWithText;
		if (textObject != null)
		{
			Debug.Log(textObject.Text);
		}
	}

	public void OnBranchesUpdated(IList<Branch> aBranches)
	{
		// just store the first branch on every pause
		if (aBranches.Count > 0)
			firstBranch = aBranches[0];
	}

	// Update is called once per frame
	void Update()
	{
		// Once paused the flow player waits until we call Play() to let it continue, that way we can finish reading the text we
		// printed to the console, and when we are done, we hit Space to finally let the flow player resume.

		//Trigger le Play() au clic sur le boutton au lieu du space

		if (Input.GetKeyUp(KeyCode.Space))
		{
			if (firstBranch != null)
				GetComponent<ArticyFlowPlayer>().Play(firstBranch);
		}
	}
}