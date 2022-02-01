using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : ScriptableObject, IPowerup
{
   public float PowerLevel { get; set; } 
}

public interface IPowerup
{
   public float PowerLevel { get; set; }
}
