using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class ScrollBind: MonoBehaviour {
    public ScrollRect scrollView;
    public void onMyFun(PointerEventData eventData)
    {
        scrollView.OnDrag(eventData);
        Debug.Log(eventData);
    }

    public void MyFun(PointerEventData a)
    {
        Debug.Log(1);
    }

    // Start is called before the first frame update
    void Start() {


    }

    // Update is called once per frame
    void Update() {



    }


}