﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class infoController : MonoBehaviour {

    public Button m_YourFirstButton;

    // Use this for initialization
    void Start()
    {
        Button btn1 = m_YourFirstButton.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(3);

    }
}
