using System.Collections.Generic;
using UnityEngine;

public class HerbColorSetter : MonoBehaviour
{
    // Dictionary to store herb names and their corresponding colors
    private Dictionary<string, Color> herbColors = new Dictionary<string, Color>
    {
        {"�����", new Color(0.682f, 0.577f, 0.578f)},
        {"�˲�", new Color(0.627f, 0.627f, 0.627f)},
        {"����", new Color(0.650f, 0.681f, 0.666f)},
        {"����", new Color(0.715f, 0.503f, 0.298f)},
        {"�ʲ�", new Color(0.750f, 0.523f, 0.377f)},
        {"޲����", new Color(0.752f, 0.572f, 0.476f)},
        {"�۹�", new Color(0.573f, 0.629f, 0.641f)},
        {"�ױⶹ", new Color(0.725f, 0.611f, 0.566f)},
        {"ɽҩ", new Color(0.682f, 0.475f, 0.196f)},
        {"����", new Color(0.761f, 0.558f, 0.495f)},
        {"����", new Color(0.702f, 0.606f, 0.583f)},
        {"�˸ʲ�", new Color(0.770f, 0.510f, 0.386f)},
        {"����", new Color(0.910f, 0.306f, 0.235f)},
        {"��Ƥ", new Color(0.596f, 0.676f, 0.682f)},
        {"����", new Color(0.840f, 0.322f, 0.215f)},
        {"���", new Color(0.495f, 0.553f, 0.568f)},
        {"����", new Color(0.808f, 0.434f, 0.417f)},
        {"��", new Color(0.625f, 0.356f, 0.314f)},
        {"��ζ��", new Color(0.682f, 0.577f, 0.578f)},
        {"����", new Color(0.000f, 0.486f, 0.502f)},
        {"��ǰ��", new Color(0.438f, 0.303f, 0.277f)},
        {"����", new Color(0.616f, 0.713f, 0.710f)},
        {"��ػ�", new Color(0.081f, 0.309f, 0.364f)},
        {"����", new Color(0.630f, 0.732f, 0.725f)},
        {"��֦", new Color(0.761f, 0.515f, 0.503f)},
        {"����", new Color(0.508f, 0.332f, 0.229f)},
        {"������", new Color(0.790f, 0.486f, 0.372f)},
        {"��к", new Color(0.296f, 0.355f, 0.372f)},
        //{"ĵ��Ƥ", new Color(-0.098f, 0.459f, 0.485f)},
        {"ĵ��Ƥ", new Color(0.00f, 0.459f, 0.485f)},
        {"�����", new Color(0.437f, 0.328f, 0.269f)},
        {"��˿��", new Color(0.591f, 0.370f, 0.198f)},
        //{"¹�ǽ�", new Color(-0.063f, 0.257f, 0.337f)},
        {"¹�ǽ�", new Color(0.00f, 0.257f, 0.337f)},
        {"ţϥ", new Color(0.456f, 0.306f, 0.242f)},
        {"�ư�", new Color(0.327f, 0.406f, 0.415f)},
        {"֪ĸ", new Color(0.518f, 0.350f, 0.322f)},
        {"��ɳ��", new Color(0.630f, 0.370f, 0.338f)},
        {"�����", new Color(0.245f, 0.425f, 0.440f)},
        //{"ɽ����", new Color(-0.190f, 0.350f, 0.407f)},
        {"ɽ����", new Color(0.00f, 0.350f, 0.407f)},
        {"����", new Color(0.684f, 0.378f, 0.153f)},
        {"���", new Color(0.625f, 0.349f, 0.180f)},
        {"����", new Color(0.235f, 0.285f, 0.325f)},
        {"������", new Color(0.000f, 0.192f, 0.294f)},
        {"�����", new Color(0.128f, 0.352f, 0.392f)},
        {"ʯ��", new Color(0.408f, 0.345f, 0.341f)},
        {"����", new Color(0.544f, 0.582f, 0.596f)},
        {"����", new Color(0.673f, 0.470f, 0.206f)},
        {"ɰ��", new Color(0.615f, 0.718f, 0.716f)},
        {"����̿", new Color(0.565f, 0.560f, 0.573f)},
        {"�ػ�", new Color(0.368f, 0.281f, 0.279f)},
        {"��׽�", new Color(0.281f, 0.252f, 0.282f)},
        {"���", new Color(0.313f, 0.255f, 0.274f)},
        {"ʯ����", new Color(0.612f, 0.680f, 0.681f)},
        {"������", new Color(0.095f, 0.262f, 0.330f)},
        {"����֬", new Color(0.602f, 0.691f, 0.694f)},
        {"������", new Color(0.773f, 0.528f, 0.493f)},
        {"������", new Color(0.435f, 0.314f, 0.258f)},
        {"ľ��", new Color(0.626f, 0.708f, 0.701f)},
        {"Զ־", new Color(0.618f, 0.638f, 0.643f)},
        {"��ܺ", new Color(0.558f, 0.522f, 0.533f)}
    };

    void Start()
    {

        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (var herb in herbColors)
        {
            foreach (var obj in allObjects)
            {

                if (obj.name == herb.Key)
                {
                    // Set the color of the game object
                    Renderer renderer = obj.GetComponent<Renderer>();
                    if (renderer != null)
                    {
                        renderer.material.color = herb.Value;
                    }
                }
            }
        }
    }

}
