using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColoringAndRealObject : MonoBehaviour
{
    [Header("Earth")]
    [SerializeField] private GameObject ColoringEarth;
    [SerializeField] private GameObject RealEarth;


    [Header("Heart")]
    [SerializeField] private GameObject ColoringHeart;
    [SerializeField] private GameObject RealHeart;

    [Header("Digistive")]
    [SerializeField] private GameObject ColoringDigistive;
    [SerializeField] private GameObject RealDigistive;

    [Header("Respiratory")]
    [SerializeField] private GameObject ColoringRespiratory;
    [SerializeField] private GameObject RealRespiratory;

    [Header("Urinary")]
    [SerializeField] private GameObject ColoringUrinary;
    [SerializeField] private GameObject RealUrinary;

    [Header("Stomach")]
    [SerializeField] private GameObject ColoringStomach;
    [SerializeField] private GameObject RealStomach;

    [Header("Liver")]
    [SerializeField] private GameObject ColoringLiver;
    [SerializeField] private GameObject RealLiver;

    [Header("Circ")]
    [SerializeField] private GameObject ColoringCirc;
    [SerializeField] private GameObject RealCirc;

    [Header("Nurv")]
    [SerializeField] private GameObject ColoringNurv;
    [SerializeField] private GameObject RealNurv;

    [Header("Apple")]
    [SerializeField] private GameObject ColoringApple;
    [SerializeField] private GameObject RealApple;

    [Header("B_Bee")]
    [SerializeField] private GameObject ColoringB_Bee;
    [SerializeField] private GameObject RealB_Bee;

    [Header("C_Cat")]
    [SerializeField] private GameObject ColoringC_Cat;
    [SerializeField] private GameObject RealC_Cat;

    [Header("D_Dog")]
    [SerializeField] private GameObject ColoringD_Dog;
    [SerializeField] private GameObject RealD_Dog;

    [Header("E_Elephant")]
    [SerializeField] private GameObject ColoringE_Elephant;
    [SerializeField] private GameObject RealE_Elephant;

    [Header("F_Fish")]
    [SerializeField] private GameObject ColoringF_Fish;
    [SerializeField] private GameObject RealF_Fish;

    [Header("G_Giraffe")]
    [SerializeField] private GameObject ColoringG_Giraffe;
    [SerializeField] private GameObject RealG_Giraffe;

    public void ChangeGameObject(int x) // 1->Earth 2 ->Heart 3->Digistive 4->Respiratory 5->Urinary 6->Stomach 7->Liver 8->Circ 9->Nurv 10->Apple 11->B_Bee 12->C_Cat 13->D_Dog 14->E_Elephant 15->F_Fish 16->G_Giraffe
    {
        if(x == 1)
        {
            if (ColoringEarth.activeInHierarchy)
            {
                ColoringEarth.SetActive(false);
                RealEarth.SetActive(true);
            }
            else
            {
                RealEarth.SetActive(false);
                ColoringEarth.SetActive(true);
            }
        }else if(x == 2)
        {
            if (ColoringHeart.activeInHierarchy)
            {
                ColoringHeart.SetActive(false);
                RealHeart.SetActive(true);
            }
            else
            {
                RealHeart.SetActive(false);
                ColoringHeart.SetActive(true);
            }
        }
        else if (x == 3)
        {
            if (ColoringDigistive.activeInHierarchy)
            {
                ColoringDigistive.SetActive(false);
                RealDigistive.SetActive(true);
            }
            else
            {
                RealDigistive.SetActive(false);
                ColoringDigistive.SetActive(true);
            }
        }
        else if (x == 4)
        {
            if (ColoringRespiratory.activeInHierarchy)
            {
                ColoringRespiratory.SetActive(false);
                RealRespiratory.SetActive(true);
            }
            else
            {
                RealRespiratory.SetActive(false);
                ColoringRespiratory.SetActive(true);
            }
        }
        else if (x == 5)
        {
            if (ColoringUrinary.activeInHierarchy)
            {
                ColoringUrinary.SetActive(false);
                RealUrinary.SetActive(true);
            }
            else
            {
                RealUrinary.SetActive(false);
                ColoringUrinary.SetActive(true);
            }
        }
        else if (x == 6)
        {
            if (ColoringStomach.activeInHierarchy)
            {
                ColoringStomach.SetActive(false);
                RealStomach.SetActive(true);
            }
            else
            {
                RealStomach.SetActive(false);
                ColoringStomach.SetActive(true);
            }
        }
        else if (x == 7)
        {
            if (ColoringLiver.activeInHierarchy)
            {
                ColoringLiver.SetActive(false);
                RealLiver.SetActive(true);
            }
            else
            {
                RealLiver.SetActive(false);
                ColoringLiver.SetActive(true);
            }
        }
        else if (x == 8)
        {
            if (ColoringCirc.activeInHierarchy)
            {
                ColoringCirc.SetActive(false);
                RealCirc.SetActive(true);
            }
            else
            {
                RealCirc.SetActive(false);
                ColoringCirc.SetActive(true);
            }
        }
        else if (x == 9)
        {
            if (ColoringNurv.activeInHierarchy)
            {
                ColoringNurv.SetActive(false);
                RealNurv.SetActive(true);
            }
            else
            {
                RealNurv.SetActive(false);
                ColoringNurv.SetActive(true);
            }
        }
        else if (x == 10)
        {
            if (ColoringApple.activeInHierarchy)
            {
                ColoringApple.SetActive(false);
                RealApple.SetActive(true);
            }
            else
            {
                RealApple.SetActive(false);
                ColoringApple.SetActive(true);
            }
        }
        else if (x == 11)
        {
            if (ColoringB_Bee.activeInHierarchy)
            {
                ColoringB_Bee.SetActive(false);
                RealB_Bee.SetActive(true);
            }
            else
            {
                RealB_Bee.SetActive(false);
                ColoringB_Bee.SetActive(true);
            }
        }
        else if (x == 12)
        {
            if (ColoringC_Cat.activeInHierarchy)
            {
                ColoringC_Cat.SetActive(false);
                RealC_Cat.SetActive(true);
            }
            else
            {
                RealC_Cat.SetActive(false);
                ColoringC_Cat.SetActive(true);
            }
        }
        else if (x == 13)
        {
            if (ColoringD_Dog.activeInHierarchy)
            {
                ColoringD_Dog.SetActive(false);
                RealD_Dog.SetActive(true);
            }
            else
            {
                RealD_Dog.SetActive(false);
                ColoringD_Dog.SetActive(true);
            }
        }
        else if (x == 14)
        {
            if (ColoringE_Elephant.activeInHierarchy)
            {
                ColoringE_Elephant.SetActive(false);
                RealE_Elephant.SetActive(true);
            }
            else
            {
                RealE_Elephant.SetActive(false);
                ColoringE_Elephant.SetActive(true);
            }
        }
        else if (x == 15)
        {
            if (ColoringF_Fish.activeInHierarchy)
            {
                ColoringF_Fish.SetActive(false);
                RealF_Fish.SetActive(true);
            }
            else
            {
                RealF_Fish.SetActive(false);
                ColoringF_Fish.SetActive(true);
            }
        }
        else if (x == 16)
        {
            if (ColoringG_Giraffe.activeInHierarchy)
            {
                ColoringG_Giraffe.SetActive(false);
                RealG_Giraffe.SetActive(true);
            }
            else
            {
                RealG_Giraffe.SetActive(false);
                ColoringG_Giraffe.SetActive(true);
            }
        }
    }
}
