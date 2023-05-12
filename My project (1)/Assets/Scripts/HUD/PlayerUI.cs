using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public GameObject countCoin;
    public GameObject countSouls;
    public GameObject countKeys;

    public GameObject attackSpeed;
    public GameObject moveSpeed;
    public GameObject damage;
    public GameObject maxHealth;
    public GameObject killCount;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        countCoin.GetComponent<Text>().text = PlayerStats.plStats.bitCoins.ToString();
        countSouls.GetComponent<Text>().text = PlayerStats.plStats.souls.ToString();
        countKeys.GetComponent<Text>().text = PlayerStats.plStats.keys.ToString();

        moveSpeed.GetComponent<Text>().text = PlayerStats.plStats.speed.ToString();
        damage.GetComponent<Text>().text = PlayerStats.plStats.maxDamage.ToString();
        maxHealth.GetComponent<Text>().text = PlayerStats.plStats.maxHealth.ToString();
        attackSpeed.GetComponent<Text>().text = PlayerStats.plStats.force.ToString();
        killCount.GetComponent<Text>().text = PlayerStats.plStats.killCount.ToString();
    }
}
