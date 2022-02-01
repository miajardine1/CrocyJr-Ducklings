using UnityEngine;

public partial interface IPowerUp
{
    public float PowerLevel { get; set; }
}

public interface IPool
{
    public void AddToPool(GameObject obj);
}

