using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct TeamInitData
{
    public Team Team;
    public List<Vector3> StartLocations;
}

public class BoardManager : MonoBehaviour
{
    private List<Player> _players;

    public List<TeamInitData> InitDatas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
