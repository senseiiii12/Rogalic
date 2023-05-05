using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class ScriptEnemy : MonoBehaviour
{
    public int health = 100;
    public GameObject pref;
    GameObject player;
    public float force;
    public float cooldown;
    public GameObject prefCoin;

    public int minDamage;
    public int maxDamage;
    PlayerStats stats;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("enemyShooting", cooldown, cooldown);
        stats = GameObject.FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        Instantiate(prefCoin, gameObject.transform.position, Quaternion.identity);
    }
    void enemyShooting()
    {
        GameObject spell = Instantiate(pref, transform.position, Quaternion.identity);
        Vector2 mPosition = player.GetComponent<Transform>().position;
        Vector2 myPosition = transform.position;
        Vector2 direction = mPosition - myPosition;
        spell.GetComponent<Rigidbody2D>().velocity = direction * force;
        Destroy(spell, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = UnityEngine.Random.Range(minDamage, maxDamage);
        PlayerMove player = collision.GetComponent<PlayerMove>();
        if (player != null)
        {
            stats.getDamage(damage); 
        }
    }
}
