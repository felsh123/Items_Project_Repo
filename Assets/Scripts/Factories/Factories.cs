using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factories
{
    public interface GameItemFactory
    {
        //La diferencia entre una Interfaz y una Clase abstracta: La interfaz solo declara métodos
        Items GetItems(string id);

    }

    public class WeaponsFactory : GameItemFactory
    {
        public Items GetItems(string id)
        {
            switch(id)
            {
                case "axe" : return new W_M_Axe();
                case "sword" : return new W_M_Sword();
                case "bow" : return new W_D_Bow();
                default : return null;
            }
        }
    }
    
    public class PotionFactory : GameItemFactory
    {
        public Items GetItems(string id)
        {
            switch(id)
            {
                case "hp_potion" : return new HP_Potion();
                case "mana_potion" : return new Mana_Potion();
                case "antidote_potion" : return new Antidote_Potion();
                default : return null;
            }
        }
    }












}
