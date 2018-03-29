using Articy.Unity;
using Articy.Unity.Interfaces;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyDialogueHandler : MonoBehaviour, IArticyFlowPlayerCallbacks
{
	// every pause we remember the very first branch, so we can continue the flow using it
	private Branch firstBranch;

	public bool showFalseBranches = false;
	public GameObject branchPrefab;
	public RectTransform branchLayoutPanel;
	private ArticyFlowPlayer flowPlayer;

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



	// we clear all old branch buttons
		ClearAllBranches();

		// for every branch provided by the flow player, we will create a button in our vertical list
		foreach (var branch in aBranches)
		{
			// if the branch is invalid, because a script evaluated to false, we don't create a button, unless we want to see false branches.
			if (!branch.IsValid && !showFalseBranches) continue;

			// we create a our button prefab and parent it to our vertical list
			var btn = Instantiate(branchPrefab);
			var rect = btn.GetComponent<RectTransform>();
			rect.SetParent(branchLayoutPanel, false);

			// here we make sure to get the Branch component from our button, either by referencing an already existing one, or by adding it.
			var branchBtn = btn.GetComponent<ArticyDebugBranch>();
			if(branchBtn == null)
				branchBtn = btn.AddComponent<ArticyDebugBranch>();

			// this will assign the flowplayer and branch and will create a proper label for the button.
			branchBtn.AssignBranch(flowPlayer, branch);
		}



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


	private void ClearAllBranches()
	{
		foreach (Transform child in branchLayoutPanel)
			Destroy(child.gameObject);
	}

}