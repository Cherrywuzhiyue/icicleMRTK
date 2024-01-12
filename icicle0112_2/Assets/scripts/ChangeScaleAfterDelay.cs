using UnityEngine;

public class ChangeScaleAfterDelay : MonoBehaviour
{
    public Vector3 newScale = new Vector3(1.0f, 1.0f, 1.0f); // 设置新的缩放值
    public float delay = 1.0f; // 延迟时间，以秒为单位

    void Start()
    {
        // 在延迟时间后调用ChangeScale方法
        Invoke("ChangeScale", delay);
    }

    void ChangeScale()
    {
        // 更改物体的scale
        transform.localScale = newScale;
    }
}
