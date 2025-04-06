using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text textAsset;

    private void Update()
    {
        textAsset.text = TimeSpan.FromSeconds(Time.time).ToString("mm\\:ss");
    }
}
