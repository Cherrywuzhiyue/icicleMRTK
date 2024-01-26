using UnityEngine;
using TMPro; // 如果使用 TextMeshPro


public class IcicleInteraction : MonoBehaviour
{
    public Canvas textCanvas; // 指向上面创建的 Canvas
    public TextMesh infoText; // 指向 Canvas 下的 TextMeshPro 文本组件

    void Start()
    {
        // 确保文本框初始时不可见
        textCanvas.gameObject.SetActive(false);
    }

    // 当用户点击或触发某个 icicle prefab 时调用
    public void OnIcicleClicked(Node icicleNode)
    {
        // 显示文本框并更新信息
        infoText.text = icicleNode.fangji;
        textCanvas.gameObject.SetActive(true);

        // 将文本框放置在合适的位置，比如 icicle 图的下方
        //textCanvas.transform.position = /* 计算位置 */;
    }

    // 可选：创建一个方法来隐藏文本框
    public void HideInfoText()
    {
        textCanvas.gameObject.SetActive(false);
    }
}
