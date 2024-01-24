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
        // ����������ʵ�ְ���ָ��ʱ���߼�
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        // ����������ʵ���϶�ָ��ʱ���߼�
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        // ����������ʵ���ͷ�ָ��ʱ���߼�
    }
}
