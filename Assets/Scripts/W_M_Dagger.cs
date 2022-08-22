using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_M_Dagger : W_Melee
{
    public W_M_Dagger() : base(Resources.Load("MeleeWeapons/Dagger") as GameObject, "Daga Común",3,true,30f,1250)
    {

    }
}
