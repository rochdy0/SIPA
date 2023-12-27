using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Valeur{
    SIX,
    SEPT,
    HUIT,
    NEUF,
    DIX,
    VALET,
    DAME,
    ROI,
    AS
}
public enum Couleur{
    PIQUE,
    COEUR,
    CARREAU,
    TREFLE
}


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Card carte1 = new Card(Couleur.PIQUE,Valeur.HUIT);
        Debug.Log(carte1);
        Card carte2 = new Card(Couleur.CARREAU,Valeur.SEPT);
        Debug.Log(carte2);
        Card carte3 = new Card(Couleur.PIQUE,Valeur.VALET);
        Debug.Log(carte3);
        Card carte4 = new Card(Couleur.TREFLE,Valeur.AS);
        Debug.Log(carte4);

        CardStack test_main = new CardStack();
        test_main.addCard(carte1);
        test_main.addCard(carte2);
        test_main.addCard(carte3);
        test_main.addCard(carte4);
        Debug.Log(test_main);

        

        Player bastien = new Player("bastien");
        Player rochdy = new Player("rochdy");
        Player sokem = new Player("sokem");
        List<Player> liste = new List<Player>(){bastien, rochdy, sokem};

        Round round_test = new Round(liste);
        Debug.Log(round_test.getStack().ToString());
        foreach(Player p in round_test.getList()){
            Debug.Log(p);
        }
        Debug.Log(round_test.getStack().ToString());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
