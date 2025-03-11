using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour //싱글톤 생성
{
    private static CharacterManager _instance;
    public static CharacterManager Instance
    {
        get
        {
            if (_instance == null) //null 이더라도 
            {
                _instance = new GameObject("CharacterManager").AddComponent<CharacterManager>();// 방어코드로 생성
            }
            return _instance; //생성 후 반환.
        }
    }

    public Player _player;
    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
        if (_instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

}
