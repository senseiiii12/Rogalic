using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public GameObject player;
    public static PlayerStats plStats;
    public float health;
    public float maxHealth;
    public float speed;


    public GameObject hBarPlayer;
    public Slider hBarPlayerSlider;

    public int bitCoins;
    public int souls;

    public double passivHeal = 0.001;
    // Start is called before the first frame update
    void Start()
    {
        plStats = this;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        PassiveHeal();
    }
    public void getDamage(float damage)
    {
        hBarPlayer.SetActive(true);
        health -= damage;
        hBarPlayerSlider.value = health;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        SceneManager.LoadScene(1);
    }
    public void getHeal(float heal)
    {
        health += heal;
        hBarPlayerSlider.value = health;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public void PassiveHeal()
    {
        if(health >= maxHealth)
        {
            health += 0;
        }
        else
        {
            health += (float)passivHeal ;
            hBarPlayerSlider.value = health;
        }
    }
}
