using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class IcicleClickHandler : MonoBehaviour, IMixedRealityPointerHandler
{
    public IcicleInteraction interactionManager;

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        interactionManager.OnIcicleClicked(this.GetComponent<Node>());
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        // 可以在这里实现按下指针时的逻辑
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        // 可以在这里实现拖动指针时的逻辑
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        // 可以在这里实现释放指针时的逻辑
    }
}
