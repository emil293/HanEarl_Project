using UnityEngine;

public class KAfterDialogue : MonoBehaviour
{
    [SerializeField] private GameObject BeforeObj;
    [SerializeField] private GameObject NewObj;
    [SerializeField] private GameObject BeforeObj2;
    [SerializeField] private GameObject NewObj2;
    [SerializeField] private GameObject BeforeObj3;
    [SerializeField] private GameObject NewObj3;
    [SerializeField] private GameObject BeforeObj4;
    [SerializeField] private GameObject NewObj4;
    public void Used()
    {
        if (BeforeObj != null)
        {
            BeforeObj.SetActive(false);
        }
        if (NewObj != null)
        {
            NewObj.SetActive(true);
        }
        if (BeforeObj2 != null)
        {
            BeforeObj2.SetActive(false);
        }
        if (NewObj2 != null)
        {
            NewObj2.SetActive(true);
        }
        if (BeforeObj4 != null)
        {
            BeforeObj4.SetActive(false);
        }
        if (NewObj4 != null)
        {
            NewObj4.SetActive(true);
        }
    }

    public void Used1()
    {
        if (NewObj != null)
        {
            NewObj.SetActive(true);
        }
    }

    public void Used2()
    {
        if (NewObj3 != null)
        {
            NewObj3.SetActive(true);
        }
    }

    public void GetItem(string itemName)
    {
        
    }
}
