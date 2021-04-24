using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]

public class EnemyHealth : MonoBehaviour
{
    [Tooltip("Adds amount to max hit points when enemy dies")]
    [SerializeField] int difficultyRamp = 1;

    [SerializeField] int maxHitPoints = 5;

    int currentHitPoints = 0;

    Enemy enemy;

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }
    // Start is called before the first frame update
    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnParticleCollision(GameObject other)
    {
        processHit();

    }

    private void processHit()
    {
        currentHitPoints--;
        if (currentHitPoints <= 0)
        {
            gameObject.SetActive(false);
            maxHitPoints += difficultyRamp;
            enemy.RewardGold();

        }
    }
}
