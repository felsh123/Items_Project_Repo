using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_M_PikeBall : W_Melee
{
    public W_M_PikeBall() : base(Resources.Load("MeleeWeapons/PikeBall") as GameObject, "Maza Común",6,false,35f,1350)
    {

    }
}
