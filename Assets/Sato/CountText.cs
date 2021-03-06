using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountText : MonoBehaviour
{
    // ///////////////////////
    /* カウントするテキスト */
    // ///////////////////////

    Text text;
    // カウントがこれになったら隠す
    [Range(0,3)]
    [SerializeField] int _invisibleCount;
    
    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Start()
    {

    }

    void Update()
    {
        
    }

    // カウントの更新、
    public void SetCount(int count)
    {
        text.text = count.ToString();
        if (_invisibleCount >= count) text.color = Color.clear;
    }
}
