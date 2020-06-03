using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue; // Accès à la classe (notre script) Dialogue. Nom de l'accès "dialogue". Là où se trouve les phrases qui vont trigger.

    public void TriggerDialogue() // Fonction qui déclanchera tout le processus de la discution. Appelé via un bouton OnClick
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue); // Trouve moi le gameobject DialogueManager et lance sa fonction StartDialogue avec comme paramètre notre classe dialogue
    }

}
