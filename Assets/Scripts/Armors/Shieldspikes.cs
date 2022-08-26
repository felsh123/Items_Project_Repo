using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shieldspikes : Armor
{
    public Shieldspikes() : base(Resources.Load("Items/ShieldPikes") as GameObject, "Escudo de Espinas",4,350,560)
    {

    }

}


