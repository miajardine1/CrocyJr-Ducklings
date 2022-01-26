using UnityEngine;

public abstract class HeathBase : MonoBehaviour, IHealth
{
public float Health { get; set;}
public void Start()
{
Health = 100f;
}

public void Run()
{
Health--;
}
}

public interface IHealth
{
float Health { get; set; }
public void Start();
public void Run();
    
}
