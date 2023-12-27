using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStack
{
    private List<Card> list;

    public CardStack(List<Card> stack){
        list = stack;
    }
    public CardStack(){
        list = new List<Card>();
    }
    public Card getCard(int position){
        return list[position];
    }

    public void addCard(Card carte){
        list.Add(carte);
    }

    public Card removeCard(int position){
        Card res = list[position];
        list.RemoveAt(position);
        return res;
    } 

    public override string ToString(){
        string res = "[ ";
        foreach(Card c in list){
            res += c.ToString()+",\n";
        }
        res+= "]";
        return res;
    }
}
