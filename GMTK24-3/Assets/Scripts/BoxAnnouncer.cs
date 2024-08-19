using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxTextCounter : MonoBehaviour
{
    public TMP_Text  text;

    // Update is called once per frame
    void Update()
    {
        text.SetText($"Boxes Left: {GameObject.FindGameObjectsWithTag("Box").Length}");
    }
}
