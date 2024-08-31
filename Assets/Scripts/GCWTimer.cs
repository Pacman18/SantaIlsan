using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GCWTimer 
{
    public delegate void TimeCheckAction(int second);

    private TimeCheckAction _timeAction;

    public void AddTimeActionListener(TimeCheckAction listener)
    {
        _timeAction += listener; 
    }

    private float _accTime; // 누적시간 체크용
    private int _accSecond; // 누적 초    
    public void Update()
    {
        _accTime += Time.deltaTime;

        if(_accTime >= 1)
        {
            _accSecond++;
            _accTime = 0;

            if (_timeAction != null)
                _timeAction.Invoke(_accSecond);
        }        
    }

    public GCWTimer()
    {
        _accTime = 0;
        _accSecond = 0;
    }


}
