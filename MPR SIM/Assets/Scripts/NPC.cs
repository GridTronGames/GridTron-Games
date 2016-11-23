using UnityEngine;
using System.Collections;

public class NPC : Interactable {
	public string[] dialogue;
	public string npcName;

	public override void Interact(){
		DialogueManager.Instance.AddNewDialogue (dialogue, npcName);
		Debug.Log ("Interacting with a NPC.");
	}
}
