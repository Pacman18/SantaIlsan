using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    private float _accTime; // �����ð� üũ��
    private int _accSecond; // ���� ��    

    private Text _countDownText;

    private void Start()
    {
        _countDownText =GetComponent<Text>();   
    }

    public void Update()
    {
        _accTime += Time.deltaTime;

        if (_accTime >= 1)
        {
            _accSecond++;
            _countDownText.text = _accTime.ToString();
        }
    }
}
