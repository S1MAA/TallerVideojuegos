using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STATS : MonoBehaviour
{
public int vidaHero;
public int coins;
public int keys;

public Text textoVida;

public Text textoCoins;
    void Start()
    {
        mostrarVidas();
        mostrarCoins();
    }

    void Update()
    {
        
    }

    public void mostrarVidas()
    {
        textoVida.text =vidaHero.ToString();
    }

    public void mostrarCoins()
    {
        textoCoins.text = coins.ToString();
    }

}
