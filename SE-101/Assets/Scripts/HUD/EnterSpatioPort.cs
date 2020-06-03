using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSpatioPort : MonoBehaviour
{
    public bool GameIsFreeze = false;
    public GameObject SpatioPortMenu;
    public PlayerMove Player;
    public Collider2D Atterisseur;

    
    
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Atterisseur")
        {
            freeze();
        }
    }

    void freeze()
    {
        SpatioPortMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsFreeze = true;
    }

    public void CosmoBar()
    {
        Debug.Log("Vous rentrez dans la taverne");
    }
    public void Garage()
    {
        Debug.Log("Vous accedez au garage");
    }

    public void Decoller()
    {
        Debug.Log("Vous quittez la station, bon voyage !");
        Time.timeScale = 1f;
        SpatioPortMenu.SetActive(false);
        float nextVX = Mathf.Cos(Player.angleRad) * 6;
        float nextVY = Mathf.Sin(Player.angleRad) * 6;
        Player.vX += nextVX;
        Player.vY += nextVY;
        GameIsFreeze = false;
    }

}
