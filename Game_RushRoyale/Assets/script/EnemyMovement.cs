using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   [Header("references")] [SerializeField]
   private Rigidbody2D rb;

   [Header("atributes")] [SerializeField] private float moveSpeed = 2f;

   private Transform target;
   private int pathIndex = 0;

   private void Start()
   {
      target = LevelMagaer.main.path[pathIndex];
      
   }

   private void Update()
   {
      if(Vector2.Distance(target.position, transform.position) <= 0.1f)
      {
         pathIndex++;
         if (pathIndex == LevelMagaer.main.path.Length)
         {
            EnemySpawner.onEnemyDestroy.Invoke();
            Destroy(gameObject);
            return;
         }
         else
         {
            target = LevelMagaer.main.path[pathIndex];
         }
      }
   }

   private void FixedUpdate()
   {
      Vector2 direction = (target.position - transform.position).normalized;

      rb.velocity = direction * moveSpeed;

   }
}
