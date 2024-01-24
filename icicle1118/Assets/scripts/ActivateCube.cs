using UnityEngine;

public class ActivateCube : MonoBehaviour
{
    public GameObject cube; // 用于在编辑器中指定Cube对象

    void Start()
    {
        // 检查是否已指定cube对象
        if (cube != null)
        {
            cube.SetActive(true); // 将Cube对象设置为active
        }
        else
        {
            Debug.LogError("Cube对象未指定！");
        }
    }
}
