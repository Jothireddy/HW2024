using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float speed = 8f; // Speed of Doofus
}

[System.Serializable]
public class PulpitData
{
    public float minPulpitDestroyTime = 4f; // Minimum time before a pulpit is destroyed
    public float maxPulpitDestroyTime = 5f; // Maximum time before a pulpit is destroyed
    public float pulpitSpawnTime = 2.5f; // Time between spawning new pulpits
}

public class GameConfig : MonoBehaviour
{
    public PlayerData playerData = new PlayerData();
    public PulpitData pulpitData = new PulpitData();
}
