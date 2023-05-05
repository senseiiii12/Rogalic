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

    //public GameObject hBarPlayer;
    //public Slider hBarPlayerSlider;

    public int bitCoins;
    public int souls;
    // Start is called before the first frame update
    void Start()
    {
        plStats = this;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getDamage(float damage)
    {
        //hBarPlayer.SetActive(true);
        //hBarPlayerSlider.value = health;
        health -= damage;
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
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
