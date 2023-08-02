using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{


    [SerializeField] private AudioSource music;


    [SerializeField] private GameObject EarthPanel;
    [SerializeField] private GameObject HeartPanel;
    [SerializeField] private GameObject DigistivePanel;
    [SerializeField] private GameObject RespiratoryPanel;
    [SerializeField] private GameObject UrinaryPanel;
    [SerializeField] private GameObject StomachPanel;
    [SerializeField] private GameObject LiverPanel;
    [SerializeField] private GameObject CircPanel;
    [SerializeField] private GameObject NurvPanel;
    [SerializeField] private GameObject ApplePanel;
    [SerializeField] private GameObject B_BeePanel;
    [SerializeField] private GameObject C_CatPanel;
    [SerializeField] private GameObject D_DogPanel;
    [SerializeField] private GameObject E_ElephantPanel;
    [SerializeField] private GameObject F_FishPanel;
    [SerializeField] private GameObject G_GiraffePanel;

    [HideInInspector] public int currentPanel = 0; // 1 -> earth , 2-> Heart , 3-> Digistive, 4->Respiratory, 5->Urinary, 6->Stomach, 7->Liver, 8->Circ, 9->Nurv, 10->Apple, 11->B_Bee, 12->C_Cat, 13->D_Dog, 14->E_Elephant, 15->F_Fish, 16->G_Giraffe


    public void EnableBtn(int x)
    {
        if(x == 1) // Earth
        {
            currentPanel = 1;
            EarthPanel.SetActive(true);
        }else if (x == 2) // Heart
        {
            currentPanel = 2;
            HeartPanel.SetActive(true);
        }
        else if (x == 3) // Digistive
        {
            currentPanel = 3;
            DigistivePanel.SetActive(true);
        }
        else if (x == 4) // Respiratory
        {
            currentPanel = 4;
            RespiratoryPanel.SetActive(true);
        }
        else if (x == 5) // Urinary
        {
            currentPanel = 5;
            UrinaryPanel.SetActive(true);
        }
        else if (x == 6) // Stomach
        {
            currentPanel = 6;
            StomachPanel.SetActive(true);
        }
        else if (x == 7) // Liver
        {
            currentPanel = 7;
            LiverPanel.SetActive(true);
        }
        else if (x == 8) // Circ
        {
            currentPanel = 8;
            CircPanel.SetActive(true);
        }
        else if (x == 9) // Nurv
        {
            currentPanel = 9;
            NurvPanel.SetActive(true);
        }
        else if (x == 10) // Apple
        {
            currentPanel = 10;
            ApplePanel.SetActive(true);
        }
        else if (x == 11) // B_Bee
        {
            currentPanel = 11;
            B_BeePanel.SetActive(true);
        }
        else if (x == 12) // C_Cat
        {
            currentPanel = 12;
            C_CatPanel.SetActive(true);
        }
        else if (x == 13) // D_Dog
        {
            currentPanel = 13;
            D_DogPanel.SetActive(true);
        }
        else if (x == 14) // E_Elephant
        {
            currentPanel = 14;
            E_ElephantPanel.SetActive(true);
        }
        else if (x == 15) // F_Fish
        {
            currentPanel = 15;
            F_FishPanel.SetActive(true);
        }
        else if (x == 16) // G_Giraffe
        {
            currentPanel = 16;
            G_GiraffePanel.SetActive(true);
        }
    }

    public void DesableBtn(int x)
    {
        if (x == 1) // Earth
        {
            EarthPanel.SetActive(false);
        }
        else if (x == 2) // Heart
        {
            HeartPanel.SetActive(false);
        }
        else if (x == 3) // Digistive
        {
            DigistivePanel.SetActive(false);
        }
        else if (x == 4) // Respiratory 
        {
            RespiratoryPanel.SetActive(false);
        }
        else if (x == 5) // Urinary 
        {
            UrinaryPanel.SetActive(false);
        }
        else if (x == 6) // Stomach 
        {
            StomachPanel.SetActive(false);
        }
        else if (x == 7) // Liver 
        {
            LiverPanel.SetActive(false);
        }
        else if (x == 8) // Circ 
        {
            CircPanel.SetActive(false);
        }
        else if (x == 9) // Nurv 
        {
            NurvPanel.SetActive(false);
        }
        else if (x == 10) // Apple 
        {
            ApplePanel.SetActive(false);
        }
        else if (x == 11) // B_Bee 
        {
            B_BeePanel.SetActive(false);
        }
        else if (x == 12) // C_Cat 
        {
            C_CatPanel.SetActive(false);
        }
        else if (x == 13) // D_Dog 
        {
            D_DogPanel.SetActive(false);
        }
        else if (x == 14) // E_Elephant 
        {
            E_ElephantPanel.SetActive(false);
        }
        else if (x == 15) // F_Fish 
        {
            F_FishPanel.SetActive(false);
        }
        else if (x == 16) // G_Giraffe 
        {
            G_GiraffePanel.SetActive(false);
        }
    }

    public void muteMusic()
    {
        music.Stop();
    }

    public void playMusic()
    {
        music.Play();
    }

}
