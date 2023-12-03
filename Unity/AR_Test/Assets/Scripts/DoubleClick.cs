using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleClick : MonoBehaviour {

    public GameObject obj;
    public Text mText;
    bool isActiveText;

    private int mouseClicks = 0;
    private float mouseTimer = 0f;
    private float mouseTimerLimit = .25f;

    void Awake()
    {
        obj.SetActive(false);
        isActiveText = false;
    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        checkMouseDoubleClick();
    }
    void checkMouseDoubleClick()
    {
        if (Input.GetMouseButtonDown(0) && GUIUtility.hotControl == 0)
        {
            mouseClicks++;
            Debug.Log("Num of mouse clicks ->" + mouseClicks);
        }

        if (mouseClicks >= 1 && mouseClicks < 3)
        {
            mouseTimer += Time.fixedDeltaTime;

            if (mouseClicks == 2)
            {
                if (mouseTimer - mouseTimerLimit < 0)
                {
                    Debug.Log("Mouse Double Click");
                    mouseTimer = 0;
                    mouseClicks = 0;

                    isActiveText = !isActiveText;
                    if (isActiveText)
                    {
                        obj.SetActive(true);
                        mText.text = "내 이름은 파형동기야~.\n방패꾸미개로 사용되었지.\n나는 김해 대성동에서 출토되었어~.";

                    }

                    /*Here you can add your double click event*/
                }
                else
                {
                    Debug.Log("Timer expired");
                    mouseClicks = 0;
                    mouseTimer = 0;
                    /*Here you can add your single click event*/
                }
            }

            if (mouseTimer > mouseTimerLimit)
            {
                Debug.Log("Timer expired");
                mouseClicks = 0;
                mouseTimer = 0;
                /*Here you can add your single click event*/
            }
        }
    }
}
