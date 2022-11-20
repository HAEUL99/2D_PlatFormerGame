using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
using System.Linq;
using ExitGames.Client.Photon;
using System.Collections.Generic;
using TMPro;

public class GameManager : MonoBehaviourPunCallbacks
{
    public GameObject[] obj;
    public static GameObject LocalPlayerInstance;
    //private ExitGames.Client.Photon.Hashtable _myCustomProperties = new ExitGames.Client.Photon.Hashtable();

    private void OnEnable()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }

    private void OnDisable()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    private void Start()
    {
        if(LocalPlayerInstance == null)
            LocalPlayerInstance = PhotonNetwork.Instantiate(obj[PhotonNetwork.LocalPlayer.ActorNumber - 1].name, gameObject.GetComponent<Transform>().position, Quaternion.identity, 0);
    }

    



}
