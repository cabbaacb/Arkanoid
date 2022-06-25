using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int _health = 3;


    //public delegate void GameRestartHandler();
    //public static event GameRestartHandler OnGameRestart;


    public int Health { get => _health; }

    public void SetDamage(int damage)
    {
        _health -= damage;
        print("Health: " + _health.ToString());
    }


}
