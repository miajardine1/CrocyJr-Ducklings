using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float minValueX = -2.75f;
    private float minValueY = -5f;
    private float spaceBetweenSquares = 1f;
    
    Vector3 RandomSpawnPosition()
    {
        float spawnPosX = minValueX + (RandomSquareIndex() * spaceBetweenSquares);
        float spawnPosY = minValueY;
        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0);
        return spawnPosition;
    }

    int RandomSquareIndex()
    {
        return Random.Range(0, 3);
    }
}
