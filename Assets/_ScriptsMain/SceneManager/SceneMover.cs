using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneMover : MonoBehaviour
{
    [Header("�ꏏ�ɃV�[���J�ڂ���I�u�W�F�N�g")]
    [SerializeField] GameObject MenuUI;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(MenuUI);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            MoveScene();
        }
    }

    public void MoveScene()
    {
        SceneManager.LoadScene("GaussShooter_Tutorial");
    }
}
