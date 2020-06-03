using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineOn : MonoBehaviour
{
    public PlayerMove Player;
    public TrailRenderer Trail;

    SpriteRenderer spriteFlamme;
    private void Awake()
    {
        spriteFlamme = GetComponent<SpriteRenderer>();
        Trail = GetComponent<TrailRenderer>();
    }

    void Update()
    {
        spriteFlamme.enabled = false;
        Trail.emitting = false;

        if (Player.fuelCurrent > 0 && Input.GetKey(KeyCode.Z))
        {
            spriteFlamme.enabled = true;
            Trail.emitting = true;
        }
    }
}
