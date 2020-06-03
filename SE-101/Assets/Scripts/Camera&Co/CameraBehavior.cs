using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraBehavior : MonoBehaviour
{
    public Camera Cam;
    public PlayerMove Player;

    


    void Update()
    {
        float playerPosX = Player.transform.position.x;
        float playerPosY = Player.transform.position.y;

        Cam.transform.position = new Vector3(playerPosX, playerPosY, -10);

        Cam.orthographicSize = Player.topSpeed * 3f;
        if (Cam.orthographicSize < 6)
        {
            Cam.orthographicSize = 6;
        }
        if (Cam.orthographicSize > 30)
        {
            Cam.orthographicSize = 30;
        }
    }


}
