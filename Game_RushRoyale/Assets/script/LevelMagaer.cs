using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMagaer : MonoBehaviour
{
   public static LevelMagaer main;

   public Transform startPoint;
   public Transform[] path;

   private void Awake()
   {
      main = this;
   }
}
