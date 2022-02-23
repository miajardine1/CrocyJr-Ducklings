using UnityEngine;

public class MethodOverLoading : MonoBehaviour
{
    public void ChangeValue(int intNum)
    {
        var newNum = intNum + 2;
        
    }

    public void ChangeValue(float floatNum)
    {
        var newNum = floatNum + 10.5f;
    }

    public int ChangeValue(int intNum, int intNum2)
    {
        return intNum + 2;
    }
}
