using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_M_Sword : W_Melee
{
    public W_M_Sword() : base(Resources.Load("MeleeWeapons/Sword") as GameObject, "Espada Común",4,true,30f,1350)
    {

    }
}
