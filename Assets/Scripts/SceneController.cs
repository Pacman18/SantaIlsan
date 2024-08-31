using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private Text _countDownText;

    public int CountDown;

    private int _remainTime;
    

    private GCWTimer _timer = new GCWTimer();

    private void Start()
    {
        _timer.AddTimeActionListener(OnTimeSecondListener);
        _timer.AddTimeActionListener(OnTextSecondListener);
        _remainTime = CountDown;

        StartCoroutine(MyUpdate());

        Debug.Log("Next Frame End");
    }


    private IEnumerator MyUpdate()
    {
        int index = 0;

        index++;
        Debug.Log("Next Frame : " + index);            
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);

    }


    private void OnTimeSecondListener(int second)
    {
        if(second == CountDown)
        {
            SceneManager.LoadScene(1);
        }
    }

    private void OnTextSecondListener(int second)
    {
        _remainTime--;
        _countDownText.text = _remainTime.ToString();
    }

    /*void Update()
    {
        _timer.Update();        
    }*/
}
