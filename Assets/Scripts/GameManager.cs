using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Debris ds;
    public AIPedestrians ai;

    public bool start = false;

    private void Awake()
    {
        Time.timeScale = 0;
        ds.enabled = false;
        ai.enabled = false;
       
    }
    public void startthegame()
    {
        Time.timeScale = 1;
        ds.enabled = true;
        ai.enabled = true;
    }


}
