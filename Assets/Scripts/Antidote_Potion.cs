using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antidote_Potion : Consumable
{
    public Antidote_Potion() : base(Resources.Load("Items/Potion_Green") as GameObject, "Antídoto", 2, 50f, 1500)
    {

    }
}
