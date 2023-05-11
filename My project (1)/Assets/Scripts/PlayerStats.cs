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
    public int maxDamage;
    public int minDamage;
    public float mana;
    public float maxMana;
    public float force;


    public Slider hBarPlayerSlider;
    public Slider sliderMana;

    public int bitCoins;
    public int souls;
    public int keys;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(getMMana(15));
        plStats = this;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        hBarPlayerSlider.value = health;
        sliderMana.value = mana;
    }
    public void getDamage(float damage)
    {
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

    public void getMana(float manaa)
    {
        mana += manaa;
        if (mana > maxMana)
        {
            mana = maxMana;
        }
    }

    IEnumerator getMMana(float manaIteration)
    {
        float difference;
        while (true)
        {
            
            difference = maxMana - mana;
            if (manaIteration > difference)
            {
                mana += difference;
                yield return null;
            }
            else
                mana += manaIteration;
                yield return new WaitForSeconds(5);
        }
    }

    
}
