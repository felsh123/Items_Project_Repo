using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_M_Staff : W_Melee
{
    public W_M_Staff() : base(Resources.Load("MeleeWeapons/Staff") as GameObject, "Bastón",4,false,25f,1250)
    {

    }
}
