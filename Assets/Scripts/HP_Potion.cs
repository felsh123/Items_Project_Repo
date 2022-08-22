using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Potion : Consumable
{
    //lo del as significo que va a actuar como X cosa, en este caso GameObject, se llama **CASTING**
    public HP_Potion() : base (Resources.Load("Items/Potion_Red") as GameObject, "Poción de Vida", 2, 50f, 1500)
    {
        
    }
}
