using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class MobileDetection : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Hello();

    [DllImport("__Internal")]
    private static extern void HelloString(string str);

    [DllImport("__Internal")]
    private static extern bool IsMobile();

    [SerializeField] private TextMeshProUGUI _output;

    void Start()
    {
        bool isMobile = false;
#if UNITY_WEBGL && !UNITY_EDITOR
        //Hello(); // Just to test that the js-unity connection works
        isMobile = IsMobile();
#endif
        _output.SetText($"Is Mobile: {isMobile}");
    }
}
