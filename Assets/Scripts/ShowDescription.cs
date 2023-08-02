using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDescription : MonoBehaviour
{
    
    [Header("Earth")]
    [SerializeField] private GameObject EarthFactsPanel;

    [Header("Heart")]
    [SerializeField] private GameObject HeartFactsPanel;

    [Header("Digistive")]
    [SerializeField] private GameObject DigistiveFactsPanel;

    [Header("Respiratory")]
    [SerializeField] private GameObject RespiratoryFactsPanel;

    [Header("Urinary")]
    [SerializeField] private GameObject UrinaryFactsPanel;

    [Header("Stomach")]
    [SerializeField] private GameObject StomachFactsPanel;

    [Header("Liver")]
    [SerializeField] private GameObject LiverFactsPanel;

    [Header("Circ")]
    [SerializeField] private GameObject CircFactsPanel;

    [Header("Nurv")]
    [SerializeField] private GameObject NurvFactsPanel;

    [Header("Apple")]
    [SerializeField] private GameObject AppleFactsPanel;

    [Header("B_Bee")]
    [SerializeField] private GameObject B_BeeFactsPanel;

    [Header("C_Cat")]
    [SerializeField] private GameObject C_CatFactsPanel;

    [Header("D_Dog")]
    [SerializeField] private GameObject D_DogFactsPanel;

    [Header("E_Elephant")]
    [SerializeField] private GameObject E_ElephantFactsPanel;

    [Header("F_Fish")]
    [SerializeField] private GameObject F_FishFactsPanel;

    [Header("G_Giraffe")]
    [SerializeField] private GameObject G_GiraffeFactsPanel;

    public void EnableFactsAndDesable(int typeFact) // 1->earth , 2 -> heart , 3-> Digistive , 4-> Respiratory , 5-> Urinary , 6-> Stomach, 7->Liver, 8->Circ, 9->Nurv , 10->Apple, 11->B_Bee, 12->C_Cat, 13->D_Dog, 14->E_Elephant, 15->F_Fish, 16->G_Giraffe
    {
        if(typeFact == 1)
        {
            EarthFactsPanel.SetActive(!EarthFactsPanel.activeInHierarchy);
        }else if (typeFact == 2)
        {
            HeartFactsPanel.SetActive(!HeartFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 3)
        {
            DigistiveFactsPanel.SetActive(!DigistiveFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 4)
        {
            RespiratoryFactsPanel.SetActive(!RespiratoryFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 5)
        {
            UrinaryFactsPanel.SetActive(!UrinaryFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 6)
        {
            StomachFactsPanel.SetActive(!StomachFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 7)
        {
            LiverFactsPanel.SetActive(!LiverFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 8)
        {
            CircFactsPanel.SetActive(!CircFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 9)
        {
            NurvFactsPanel.SetActive(!NurvFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 10)
        {
            AppleFactsPanel.SetActive(!AppleFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 11)
        {
            B_BeeFactsPanel.SetActive(!B_BeeFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 12)
        {
            C_CatFactsPanel.SetActive(!C_CatFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 13)
        {
            D_DogFactsPanel.SetActive(!D_DogFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 14)
        {
            E_ElephantFactsPanel.SetActive(!E_ElephantFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 15)
        {
            F_FishFactsPanel.SetActive(!F_FishFactsPanel.activeInHierarchy);
        }
        else if (typeFact == 16)
        {
            G_GiraffeFactsPanel.SetActive(!G_GiraffeFactsPanel.activeInHierarchy);
        }
    }

}
