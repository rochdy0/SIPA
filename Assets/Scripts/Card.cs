using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    private Couleur color;
    private Valeur value;

    public Card(Couleur color, Valeur value){
        this.color = color;
        this.value = value;
    }

    public Valeur getValue(){
        return this.value;
    }

    
    public override string ToString(){
        return this.value+" de "+this.color;
    }
}
