using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    /// <summary>Attempts to connect to the server.</summary>
    public void ConnectToServer()
    {
        Client.instance.ConnectToServer();
    }

    public void Start()
    {
        ConnectToServer();
    }
}
