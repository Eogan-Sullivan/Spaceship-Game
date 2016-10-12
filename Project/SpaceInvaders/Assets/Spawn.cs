using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject[] enemies = new GameObject[9];

    public int amount;

    private Vector3 spawnPoint;

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        amount = enemies.Length;

        if (amount < 10)
        {
            InvokeRepeating("spawnEnemy", 1, 1f);
           
        }
    }
    void spawnEnemy()
 {
  spawnPoint.x = Random.Range (-30,30);
  spawnPoint.y = Random.Range(-30,30);
  spawnPoint.z = Random.Range (-30,30);

  Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], spawnPoint, Quaternion.identity);﻿
  CancelInvoke ();
 }

    
 }