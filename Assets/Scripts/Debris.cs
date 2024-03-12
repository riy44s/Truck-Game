using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Debris : MonoBehaviour
{

    public GameObject onLoadButtonObject;
    public Button onLoadButton;
    public GameObject[] OnloadDebris;
    public GameObject[] OnloadDebrisDublocate;
    public GameObject OnloadDebrisDublocate2;
    public GameObject OnloadDebrisDublocate3;
    public int countDebris;
    public TextMeshProUGUI countext;
    public bool isCollected;



    public GameObject OnUnloadButtonObject;
    public Button onUnloadButton;
    public GameObject OnUnloadDebris;
    public bool isDeposited;
    public GameObject DepositedPanel;
    public TextMeshProUGUI depositeCount;
    public GameObject wasteCanObject;


    public int countDebrisDeposite;
    public TextMeshProUGUI countextDeposite;


    public bool isCollideWithTarget = false;
    public bool isCollideWithWasteCan = false;

    public bool isTruckOnTarget = false;


    public int currentDebrisIndex = 0;
    private int currentDublocateIndex = 0;

    public AudioClip load;
    public AudioClip unload;

    void Start()
    {
       
    }

   
    void Update()
    {

        countext.text = "Debris : "+countDebris;

        if (isCollideWithTarget)
        {
            onLoadButtonObject.SetActive(true);

            if (onLoadButton.interactable)
            {
                onLoadButton.onClick.AddListener(Onload);
            }
        }
        else
        {
            Debug.Log("Button falsing : ");
            onLoadButtonObject.SetActive(false);
        }

        if (isCollideWithWasteCan)
        {
            OnUnloadButtonObject.SetActive(true);

            if (onUnloadButton.interactable)
            {

                Debug.Log("unload calling : ");
                onUnloadButton.onClick.AddListener(OnUnload);
            }
        }
    }

    public void IncrementScore()
    {
        countDebris++;
    }
    public void Onload()
    {
        /*        if (!isTruckOnTarget)
                {
                    OnloadDebris.SetActive(false);
                }

                //isCollideWithTarget = false;

                OnloadDebris.SetActive(false);
                OnloadDebrisDublocate.SetActive(true);

                if (!isCollected)
                {
                    countDebris++;
                    countext.text = countDebris.ToString();
                    isCollected = true;
                }


                Debug.Log("OnloadDebris set to active.");
                */

        if (!isTruckOnTarget)
        {
            for (int i = 0; i < OnloadDebris.Length; i++)
            {
                Debug.Log("calling"+i);

                if (i == currentDebrisIndex)
                {
                    Debug.Log( "calling in condition : "+i);
                    OnloadDebris[i].SetActive(false);
                    OnloadDebrisDublocate[i].SetActive(true);
                    isCollideWithTarget = false;
                    
                }


            }
            AudioManeger.Instance.sfxSource.PlayOneShot(load);
            currentDebrisIndex++;
            isTruckOnTarget = true;
        }

   
    }

    public void OnUnload()
    {
        Debug.Log("unload calling function : ");


        wasteCanObject.SetActive(true);

        for (int i = 0; i < OnloadDebris.Length; i++)
        {
            OnloadDebrisDublocate[i].SetActive(false);
            countDebrisDeposite = i+1;
        }
        AudioManeger.Instance.sfxSource.PlayOneShot(unload);
        countDebris = 0;

        countextDeposite.text = "Deposite : "+countDebrisDeposite;

        DepositedPanel.SetActive(true);
        depositeCount.text = "Debris Deposited : " + countDebrisDeposite;
        Time.timeScale = 0;
     
    }


}
