using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted);
    }

    private void Update()
    {
        Vector3 displacement = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
            displacement.y += 1;
        if(Input.GetKey(KeyCode.S))
            displacement.y += -1;
        if(Input.GetKey(KeyCode.A))
            displacement.x += -1;
        if(Input.GetKey(KeyCode.D))
            displacement.x += 1;
        _playerTransform.position += displacement.normalized * _speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
            PlantSeed();
    }

    public void PlantSeed ()
    {
        if(_numSeedsLeft > 0)
        {
            Instantiate(_plantPrefab,_playerTransform.position,Quaternion.identity);
            _numSeedsLeft += -1;
            _numSeedsPlanted += 1;
            _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted);
        }
    }
}
