using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour
{
    // ///////////////////////
    /* �J�E���g����e�L�X�g */
    // ///////////////////////

    Text text;
    // �J�E���g������ɂȂ�����B��
    int _invisibleCount;
    
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        
    }

    // �J�E���g�̍X�V�A
    public void SetCount(int count)
    {
        text.text = count.ToString();
    }
}
