using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReactiveWall : MonoBehaviour
{
    public int broadcastCode = 0;

    // Update is called once per frame
    void LevelButtonClicked(int code){
        if(code == this.broadcastCode) gameObject.SetActive(false);
    }
}
