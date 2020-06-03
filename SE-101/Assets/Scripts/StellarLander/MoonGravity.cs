using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonGravity : MonoBehaviour
{

    public PlayerMove Player;
    public float gravityPower;
    public float masse;
    public float AngleAstreDeg;
    public float VitesseRotation;
    public bool attraction;
    float distanceAB;
    float angleAB; // angle entre l'astre et le player


    // Update is called once per frame
    void Update()
    {
        float distanceX = Mathf.Pow(transform.position.x - Player.transform.position.x, 2);
        float distanceY = Mathf.Pow(transform.position.y - Player.transform.position.y, 2);
        distanceAB = Mathf.Sqrt(distanceX) + Mathf.Sqrt(distanceY);


        gravityPower = masse / distanceAB;

        if (distanceAB < 100)
        {
            attraction = true;
            angleAB = Mathf.Atan2((transform.position.y - Player.transform.position.y), (transform.position.x - Player.transform.position.x));
            float attractX = (gravityPower * Time.deltaTime) * Mathf.Cos(angleAB);
            float attractY = (gravityPower * Time.deltaTime) * Mathf.Sin(angleAB);

            Player.vX += attractX;
            Player.vY += attractY;
            AngleAstreDeg = Mathf.Rad2Deg * angleAB;
        }
        else
        {
            attraction = false;
        }
        transform.Rotate(0, 0, VitesseRotation);

    }
}