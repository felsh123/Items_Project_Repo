using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_M_Hammer : W_Melee
{
    public W_M_Hammer() : base(Resources.Load("MeleeWeapons/Hammer") as GameObject, "Martillo Común",6,false,40f,1450)
    {

    }
}
