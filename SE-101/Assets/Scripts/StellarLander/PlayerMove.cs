using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    #region Variables gloables
    public float vX;
    public float vY;
    public float angleDeg;
    public float angleRad;
    public float moveSpeed = 2f;
    public float topSpeed;
    float fuelMax = 100f;
    public float fuelCurrent;
    public float fuelConsumption;
    public EnterSpatioPort isFreeze;
    Vector3 velocite;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        fuelCurrent = fuelMax;
    }

    // Update is called once per frame
    void Update()
    {
        #region Rotation du vaisseau
        angleDeg = transform.eulerAngles.z;
        float turnSpeed = 0.45f;

        if (Input.GetKey(KeyCode.Q) && isFreeze.GameIsFreeze == false)
        {
            angleDeg += turnSpeed;
        }
        else if (Input.GetKey(KeyCode.D) && isFreeze.GameIsFreeze == false)
        {
            angleDeg -= turnSpeed;
        }


        transform.eulerAngles = new Vector3(0, 0, angleDeg);
        #endregion

        #region Poussée du vaisseau
        angleRad = angleDeg * Mathf.Deg2Rad;


        if (fuelCurrent > 0)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                fuelCurrent -= fuelConsumption;
                float nextVX = Mathf.Cos(angleRad) * (moveSpeed * Time.deltaTime);
                float nextVY = Mathf.Sin(angleRad) * (moveSpeed * Time.deltaTime);
                vX += nextVX;
                vY += nextVY;
                
            }
            if (Input.GetKey(KeyCode.S))
            {
                fuelCurrent -= fuelConsumption;
                float nextVX = Mathf.Cos(angleRad) * (moveSpeed * Time.deltaTime);
                float nextVY = Mathf.Sin(angleRad) * (moveSpeed * Time.deltaTime);
                vX -= nextVX;
                vY -= nextVY;
            }
        }
        #endregion

        #region Indicateur et limitation de vitesse
        if (Mathf.Abs(vX) >= 31)
        {
            if (vX > 0)
            {
                vX = 31;
            }
            else
            {
                vX = -31;
            }
        }
        if (Mathf.Abs(vY) >= 31)
        {
            if (vY > 0)
            {
                vY = 31;
            }
            else
            {
                vY = -31;
            }
        }
        topSpeed = Mathf.Sqrt(Mathf.Pow(vX, 2) + Mathf.Pow(vY, 2));


        #endregion

        velocite = new Vector3(vX, vY, 0);
        //velocite.Normalize();
        transform.position += velocite * Time.deltaTime;
    }

}
