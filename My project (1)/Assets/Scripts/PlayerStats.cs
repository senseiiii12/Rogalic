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
    public float killCount; 
    public float XpHero;
    public float LevelHero;
    public int skillPoint;


    public Slider hBarPlayerSlider;
    public Slider sliderMana;
    public Slider sliderXP;

    public int bitCoins;
    public int souls;
    public int keys;

    public GameObject enemy;
    public GameObject chest;

    


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(getMMana(50));
        StartCoroutine(RandomChest());
        plStats = this;
        health = maxHealth;
        CreateRandomChest();
    }

    // Update is called once per frame
    void Update()
    {
        sliderXP.value = XpHero;
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
            CreateRandomEnemy();

            difference = maxMana - mana;
            if (manaIteration > difference)
            {
                mana += difference;
                yield return null;
            }
            else
                mana += manaIteration;
                yield return new WaitForSeconds(3);
        }
    }
    public void CreateRandomEnemy()
    {
            Vector3 point = new Vector3(UnityEngine.Random.Range(-17, 17), UnityEngine.Random.Range(-8, 8), 0) + transform.position;
            Instantiate(enemy, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));     
    }

    public void CreateRandomChest()
    {  
            Vector3 point = new Vector3(UnityEngine.Random.Range(-17, 17), UnityEngine.Random.Range(-8, 8), 0) + transform.position;
            Instantiate(chest, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));  
    }

    IEnumerator RandomChest()
    {
        while (true)
        {
            CreateRandomChest();
            yield return new WaitForSeconds(16);
        }
    }

    


}
