using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana_Potion : Consumable
{
    public Mana_Potion() : base(Resources.Load("Items/Potion_Blue") as GameObject, "Poción de Maná", 2, 50f, 1500)
    {

    }
}
