using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Wave
{
   public string WaveName;
   public int noOfEnemies;
   public GameObject[] typeofEnemies;
   public float spawnInterval;

}

public class WaveSpawner : MonoBehaviour
{
   [SerializeField]  Wave[] waves;
   public Transform[] spawnPoints;

   

}



 void Update()
{
 
}


void SpawnWave()
{
   
}