using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText; // Appel de la classe Text qui va gérer l'apparition des lettres dans la bulle des dialogues (l'effet animation)

    public Animator animator; // Appel de la classe Animator qui va gérer l'apparition de la boite de dialogue

    private Queue<string> sentences; // Appel de la classe Queue qui va contenir les différentes phrases dans une queue (comme une liste[] mais en plus spécifique)

    public float speed;



    void Start() // Au démarrage
    {
        sentences = new Queue<string>(); // Initialise la liste de phrases
    }

    public void StartDialogue (Dialogue dialogue) // Fonction gérant le lancement d'une discution
    {
        animator.SetBool("IsOpen", true); // Fait apparaitre la boite de dialogue

        sentences.Clear(); // Néttoie la liste de phrases

        foreach (string sentence in dialogue.sentences) // Pour chaque phrase dans la liste de phrase
        {
            sentences.Enqueue(sentence); // Ajoute la phrase à la liste queue
        }

        DisplayNextSentence(); // Appel la fonction DisplayNextSentence
    }
    
    public void DisplayNextSentence() // Fonction gérant le défilement des phrases
    {
        if (sentences.Count == 0) // Si la queue arrive à 0
        {
            EndDialogue(); // Appel la fonction EndDialogue
            return; // Renvoi le résultat et si condition validé sors de la fonction
        }

        string sentence = sentences.Dequeue(); // Création de la variable stockant la prochaine phrase
        StopAllCoroutines(); // Arrête toutes les courroutines
        StartCoroutine(TypeSentence(sentence)); // Commence la coroutine TypeSentence avec la phrase actuelle
    }

    IEnumerator TypeSentence (string sentence) // Création d'une coroutine prenant un string en paramètre (qui sera la phrase à afficher)
    {
        dialogueText.text = ""; // On crée l'espace où les lettres vont apparaitre
        foreach (char letter in sentence.ToCharArray()) // Pour chaque lettre dans la phrase en cours (ToCharArray = transforme un string en série de char)
        {
            dialogueText.text += letter; // Ajoute la lettre actuelle
            yield return new WaitForSeconds(speed);
            /*yield return null;*/ // Moment auquel l'exécution se mettra en pause et reprendra la trame suivante
        }
    }

    void EndDialogue() // Fonction gérant la fin d'un dialogue
    {
        animator.SetBool("IsOpen", false); // Fait disparaitre la boite de dialogue
    }


}
