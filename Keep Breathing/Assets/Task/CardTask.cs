using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardTask : MonoBehaviour
{
    public List<CardPoint> _swipePoints = new List<CardPoint>();
    public float _countdownMax = 0.5f;
    public TextMeshProUGUI textMesh;
    private int _currentSwipePointIndex = 0;
    private float _countdown = 0;

    private void Update()
    {
        _countdown -= Time.deltaTime;

        if (_currentSwipePointIndex != 0 && _countdown <= 0)
        {
            _currentSwipePointIndex = 0;
            StartCoroutine(FinishTask(false));
        }
    }
    private IEnumerator FinishTask(bool wasSuccessful)
    {
        if (wasSuccessful)
        {
            textMesh.text = "Welcome";
            Debug.Log("test");
        }
        else
        {
            textMesh.text = "Failure";
            Debug.Log("test1");
        }

        yield return new WaitForSeconds(1.5f);

        textMesh.text = "Swipe!";
        Debug.Log("test2");
    }
    public void SwipePointTrigger(CardPoint swipePoint)
    {
        if (swipePoint == _swipePoints[_currentSwipePointIndex])
        {
            _currentSwipePointIndex++;
            _countdown = _countdownMax;
        }
        if (_currentSwipePointIndex >= _swipePoints.Count)
        {
            _currentSwipePointIndex = 0;
            StartCoroutine(FinishTask(true));
        }
    }
}
