// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using TMPro;
using UnityEditor;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [AddComponentMenu("Scripts/MRTK/Examples/HandInteractionTouch")]

    public class HandInteractionTouch : MonoBehaviour, IMixedRealityTouchHandler
    {
        [SerializeField]
        private TextMesh debugMessage = null;
        [SerializeField]
        private TextMesh debugMessage2 = null;
        //public GameObject textPrefab;
        private TextMesh textMesh;
        private GameObject fjtextObj;
        private Node rootNode;
        private string fjdata;

        #region Event handlers
        public TouchEvent OnTouchCompleted;
        public TouchEvent OnTouchStarted;
        public TouchEvent OnTouchUpdated;
        #endregion

        private Renderer TargetRenderer;
        private Color originalColor;
        private Color highlightedColor;

        protected float duration = 1.5f;
        protected float t = 0;

        private void Start()
        {
            GameObject icicleObject = GameObject.Find("icicle");
            if (icicleObject != null)
            {
                Debug.Log("Find(\"icicle\")");
                // 获取 "icicle3" 脚本的引用
                icicle3 script = icicleObject.GetComponent<icicle3>();
                if (script != null)
                {
                    Debug.Log("Find(\"icicle3\")");
                    // 访问rootNode变量
                    rootNode = RootNode.rootNode;
                    Debug.Log(rootNode);
                    foreach (var child in rootNode.children)
                    {
                      if (child.name2 ==this.name)
                        {
                            GetFangjiData(this.name);

                        }
                    }

                }
            }
            GameObject parentObject = GameObject.Find("MixedRealitySceneContent"); // 替换为fjtext的父物体的名字
            fjtextObj = FindDeepChild(parentObject, "fjtext");
            if (fjtextObj != null)
            {
                // 获取TextMesh组件
                textMesh = fjtextObj.GetComponent<TextMesh>();
                if (textMesh != null)
                {
                    // 设置文本
                    textMesh.text = "方剂";
                }
            }
            fjtextObj.SetActive(false); // 初始时设置为不可见
            TargetRenderer = GetComponentInChildren<Renderer>();
            if ((TargetRenderer != null) && (TargetRenderer.sharedMaterial != null))
            {
                originalColor = TargetRenderer.sharedMaterial.color;
                highlightedColor = new Color(originalColor.r + 0.2f, originalColor.g + 0.2f, originalColor.b + 0.2f);
            }
        }

        void IMixedRealityTouchHandler.OnTouchCompleted(HandTrackingInputEventData eventData)
        {
            OnTouchCompleted.Invoke(eventData);

            if (debugMessage != null)
            {
                debugMessage.text = "OnTouchCompleted: " + Time.unscaledTime.ToString();
            }

            if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {
                TargetRenderer.material.color = originalColor;
                fjtextObj.SetActive(false);
            }
        }

        void IMixedRealityTouchHandler.OnTouchStarted(HandTrackingInputEventData eventData)
        {
            OnTouchStarted.Invoke(eventData);

            if (debugMessage != null)
            {
                debugMessage.text = "OnTouchStarted: " + Time.unscaledTime.ToString();
            }

            if (TargetRenderer != null)
            {
                TargetRenderer.sharedMaterial.color = Color.Lerp(originalColor, highlightedColor, 2.0f);
                fjtextObj.SetActive(true); // 触摸时设置为可见
                textMesh.text = "方剂:"+ fjdata; // 设置文本 
            }
        }

        void IMixedRealityTouchHandler.OnTouchUpdated(HandTrackingInputEventData eventData)
        {
            OnTouchUpdated.Invoke(eventData);

            if (debugMessage2 != null)
            {
                debugMessage2.text = "OnTouchUpdated: " + Time.unscaledTime.ToString();
            }

            if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {
                TargetRenderer.material.color = Color.Lerp(Color.green, Color.red, t);
                t = Mathf.PingPong(Time.time, duration) / duration;
                fjtextObj.SetActive(true); // 触摸时设置为可见
                textMesh.text = "方剂:" + fjdata; // 设置文本



            }
        }

        TextMeshPro FindTextMeshProComponent(string name)
        {
            foreach (TextMeshPro text in FindObjectsOfType<TextMeshPro>())
            {
                if (text.gameObject.name == name)
                {
                    return text;
                }
            }
            return null;
        }

        private GameObject FindDeepChild(GameObject parent, string childName)
        {
            foreach (Transform child in parent.transform)
            {
                if (child.name == childName)
                {
                    return child.gameObject;
                }

                GameObject found = FindDeepChild(child.gameObject, childName);
                if (found != null)
                    return found;
            }
            return null;
        }

        public string GetFangjiData(string objectName)
        {
            fjdata = "";

            foreach (var child in rootNode.children)
            {
                if (child.name2 == objectName)
                {
                    fjdata = child.fangji;
                    break; // 如果找到匹配项，则退出循环
                }
            }

            return fjdata;
        }
    }
}