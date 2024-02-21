using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoManager : MonoBehaviour
{
    private static TutoManager instance;

    public bool isOpenTuto { get; private set; }

    [SerializeField] GameObject tutoCanvas;

    private void Awake()
    {
        if (instance == null) instance = this;
        isOpenTuto = false;
        tutoCanvas.SetActive(isOpenTuto);
    }

    private void Update()
    {
        if (isOpenTuto && Input.GetKey(KeyCode.Escape)) OpenTuto();
    }

    public void OpenTuto()
    {
        tutoCanvas.SetActive(!isOpenTuto);
        isOpenTuto = !isOpenTuto;
    }

    public static TutoManager GetInstance() { return instance; }
}
