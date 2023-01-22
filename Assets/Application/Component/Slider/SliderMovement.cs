using DG.Tweening;
using UnityEngine;

public class SliderMovement : MonoBehaviour
{
    public SliderCollections[] collections;

    public void Update()
    {
#if UNITY_EDITOR_WIN
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.GetComponent<GameEventListener>() != null)
                {
                    hitInfo.collider.GetComponent<GameEventListener>().OnEventRaised();
                }
            }
        }
#endif

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray _ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit _hitInfo;
            if(Physics.Raycast(_ray,out _hitInfo))
            {
                if(_hitInfo.collider.GetComponent<GameEventListener>() != null)
                {
                    _hitInfo.collider.GetComponent<GameEventListener>().OnEventRaised();
                }
            }
        }
    }


    public void Slider(GameEventListener aSlider)
    {
        for (int i = 0; i < collections.Length; i++)
        {
            if(aSlider == collections[i].sliderListenerGO)
            {
                aSlider.GetComponent<Transform>().DOMove(collections[i].SliderFinalPosition, 2f).onComplete += () =>
                {
                    aSlider.enabled = false;
                    GameManager.Instance.TotalNumberOfEvents -= 1;
                    GameManager.Instance.CheckTotalEventComplete();
                };
            }
        }
    }
}

[System.Serializable]
public class SliderCollections
{
    public Vector3 SliderFinalPosition;
    public GameEventListener sliderListenerGO;
}