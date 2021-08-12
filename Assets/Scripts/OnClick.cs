using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    [SerializeField]
    private GameObject cameraTransform, cameraPosition, panelInfo, Manager;
    void Start()
    {
        Manager = GameObject.Find("Manager").gameObject;
        cameraTransform = GameObject.Find("MainCamera").gameObject;
        panelInfo = Manager.GetComponent<Begunci>().PanelInfo;
        cameraPosition = transform.GetChild(0).gameObject;
    }
    public void OnMouseDown()
    {
        cameraTransform.GetComponent<Controller>().destination = cameraPosition.transform.position;
        cameraTransform.GetComponent<Controller>().vra = cameraPosition.transform.rotation;
        cameraTransform.GetComponent<Controller>().movePosition = true;
        ActivePanelInfo();
    }
    void ActivePanelInfo(){
        /*

            Вводим необходимые данные в панель!

        */
        panelInfo.SetActive(true);
    }
}
