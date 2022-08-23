using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_M_Axe : W_Melee
{
    public W_M_Axe() : base(Resources.Load("MeleeWeapons/Axe") as GameObject, "Hacha Común",5,true,35f,1450)
    {

    }
}
