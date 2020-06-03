using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstreCollider : MonoBehaviour
{

    public PlayerMove Player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision detecté");
        Player.transform.position = new Vector3(0, 70, -1);
        Player.transform.eulerAngles = new Vector3(0, 0, 90);
        Player.vX = 0;
        Player.vY = 0;
    }
}
