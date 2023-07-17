
using System.Collections;

using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnManager : MonoBehaviour
{
  public GameObject duck;
  public float spawnTime;
  public WaitForSeconds wfs;

  private void Start()
  {
      wfs = new WaitForSeconds(spawnTime);
      StartCoroutine(SpawnRoutine());
  }

  public void SpawnDuck()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-2f,2f),7.5f,-1);
        spawnTime = Mathf.MoveTowards(spawnTime, 125f, .3f);
        Instantiate(duck, spawnPoint, Quaternion.identity);
    }

   public IEnumerator SpawnRoutine()
   {
       while (true)
       {
           SpawnDuck();
           yield return wfs;
       }
   }
  
}


