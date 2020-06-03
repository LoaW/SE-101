using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Minimap : MonoBehaviour
{
    public Camera Cam;
    public PlayerMove Player;




    void Update()
    {
        float playerPosX = Player.transform.position.x;
        float playerPosY = Player.transform.position.y;

        Cam.transform.position = new Vector3(playerPosX, playerPosY, -10);

        Cam.orthographicSize = 450;
    }


}
