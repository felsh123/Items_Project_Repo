using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Armor
{
    public Shield() : base(Resources.Load("Items/Shield") as GameObject, "Escudo de Madera",6,300,860)
    {

    }
}
