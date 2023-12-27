using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round
{
    private CardStack stack;
    private CardStack heap;
    private Couleur asked;
    private List<Player> list;

    public Round(List<Player> list){
        stack = new CardStack(generate_stack());
        this.list = list;   
        deal();
    }

    /*public Couleur getAsked(){

    }
*/
    public void deal(){
        foreach(Player p in list){
            for(int i=0;i<5;i++){
                p.hand.addCard(stack.removeCard(0));
            }
        }
    }

    public CardStack getStack(){
        return this.stack;
    }

    public List<Player> getList(){
        return this.list;
    }


    private void shuffle(List<Card> stack){
        int lastIndex = stack.Count -1;
        while(lastIndex > 0){
            Card tempCard  = stack[lastIndex];
            int randomIndex = Random.Range(0,lastIndex+1);
            stack[lastIndex] = stack[randomIndex];
            stack[randomIndex] = tempCard;
            lastIndex --;
        }
    }
    private List<Card> generate_stack(){
        List<Card> stack = new List<Card>();

        foreach (Valeur val in System.Enum.GetValues(typeof(Valeur))){
            foreach (Couleur col in System.Enum.GetValues(typeof(Couleur))){
                Card c = new Card(col,val);
                stack.Add(c);
        }
        }
        shuffle(stack);
        return stack;
    }

    /*public void Turn(){
        foreach(Player p in list){

        }
    }
    */

   
    
}
