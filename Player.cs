using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

    private CardStack hand;
    private string name;

    public Player(string name){
        this.name = name;
        hand = new CardStack();
    }

    public string getNom(){
        return this.name;
    }

    public override string ToString(){
        return "je m'appelle : "+this.name+" ma main est : "+hand.ToString();
    }

}


