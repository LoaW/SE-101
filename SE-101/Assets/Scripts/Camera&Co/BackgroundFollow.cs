using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public GameObject Background;
    public PlayerMove Player;

    void Update()
    {
        float playerPosX = Player.transform.position.x;
        float playerPosY = Player.transform.position.y;

        Background.transform.position = new Vector3(playerPosX, playerPosY, 2);
    
    }
}
