using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    private float _accTime; // 누적시간 체크용
    private int _accSecond; // 누적 초    

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
