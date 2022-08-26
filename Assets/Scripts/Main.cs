using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Factories;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WeaponsFactory wf = new WeaponsFactory();
        PotionFactory pf = new PotionFactory();
        Items bow = wf.GetItems("bow");
        Items hpPotion = pf.GetItems("hp_potion");
        //HP_Potion potion = new HP_Potion();
        //Debug.Log(gameObject.transform.position);
        //W_D_Bow bow = new W_D_Bow();
        //Debug.Log(bow.name);
        //Debug.Log(bow.price);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
