using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Data : ScriptableObject
{
   public Vector3 value;
   
   public void UpdateValue(Transform obj)
   {
      value = obj.position;
   }
   
   public void UpdateTransform(Transform obj)
   {
   obj.localPosition = value;
   }
}
