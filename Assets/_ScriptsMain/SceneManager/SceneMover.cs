using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneMover : MonoBehaviour
{
    [Header("�ꏏ�ɃV�[���J�ڂ���I�u�W�F�N�g")]
    [SerializeField] GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        foreach (var item in objects)
        {
            DontDestroyOnLoad(item);
        }
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
