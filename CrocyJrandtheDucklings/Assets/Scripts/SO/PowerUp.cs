using UnityEngine;
using UnityEngine.Android;

[CreateAssetMenu]
public class PowerUp : ArtBase, IPowerUp
{
 public float PowerLevel { get; set; }
 public PowerUp powerUpObj;
  public void OnMouseDown()
  {
   Destroy(powerUpObj, 2);
   //todo: update score
   //todo: chomp sound effect
  }
  
  private void OnTriggerEnter(Collider other)
  {
   //todo: invoke changeGameState Action when missed
  }

 }
