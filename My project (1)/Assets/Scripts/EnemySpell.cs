using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class EnemySpell : MonoBehaviour
{
    public int minDamage;
    public int maxDamage;
    PlayerStats stats;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        stats = GameObject.FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = Random.Range(minDamage, maxDamage);
        PlayerMove player = collision.GetComponent<PlayerMove>();
        if (player != null)
        {
            stats.getDamage(damage);
            Destroy(gameObject);
        }
    }
}
