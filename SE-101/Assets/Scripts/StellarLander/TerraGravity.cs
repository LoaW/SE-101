using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerraGravity : MonoBehaviour
{

    public PlayerMove Player;
    public EnterSpatioPort isFreeze;
    public float gravityPower;
    public float masse = 10f;
    public float AngleAstreDeg;
    public float VitesseRotation;
    public bool attraction;
    public float distanceAB;
    float angleAB; // angle entre l'astre et le player




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float distanceX = Mathf.Pow (transform.position.x - Player.transform.position.x, 2);
        float distanceY = Mathf.Pow(transform.position.y - Player.transform.position.y, 2);
        distanceAB = Mathf.Sqrt(distanceX) + Mathf.Sqrt(distanceY);


        gravityPower = masse / distanceAB;

        if (distanceAB < 300)
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

        if (isFreeze.GameIsFreeze == true)
            transform.Rotate(0, 0, 0);
        else
            transform.Rotate(0, 0, VitesseRotation);
    
        
    }

}
