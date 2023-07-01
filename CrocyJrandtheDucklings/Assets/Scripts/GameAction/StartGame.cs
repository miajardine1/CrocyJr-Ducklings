using System.Collections;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject spawnObject;
    

    public WaitForSeconds wfs;
    public float startTime;
    private void Start()
    {
        wfs = new WaitForSeconds(startTime);
        StartCoroutine(ClickSwitchRoutine());
    }
    
    public IEnumerator ClickSwitchRoutine()
    {
        while (true)
        {
            yield return wfs;
            spawnObject.gameObject.SetActive(true);
        }
    }
    
    //public void ClickSwitch()
   // {
    //    titleScreen.SetActive(false);
     //   spawnObject.gameObject.SetActive(true);
    //}
}


  
