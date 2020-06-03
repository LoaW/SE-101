using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] // Donne la permission de modifier depuis l'hud d'unity
public class Dialogue /*: MonoBehaviour*/ // "On retire le MonoBehavior car nous ne voulons pas que ce script repose sur un gameObject"
{
    [TextArea (3, 10)] // La boite de texte sera d'une hauteur de 3 et d'une largeur de 10
    public string[] sentences; // Création d'une liste contenant les phrases qui seront envoyé dans le système de queue
}
