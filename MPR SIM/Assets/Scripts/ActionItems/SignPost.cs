using UnityEngine;
using System.Collections;

public class SignPost : ActionItem {
	public string[] dialogue;

	public override void Interact(){
		DialogueManager.Instance.AddNewDialogue (dialogue, "Sign");
		Debug.Log ("Interacting with a Sign Post.");
	}
}
