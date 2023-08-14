using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AudioManager.instance.Play("音频名称");
    }
}
