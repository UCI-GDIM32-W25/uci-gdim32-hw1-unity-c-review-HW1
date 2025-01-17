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
        _playerTransform = transform;
        
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        //Move the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0) * _speed * Time.deltaTime;
        _playerTransform.position += movement;

        //Check for planting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if(_numSeedsLeft > 0)
        {
            //Instantiate the plant prefab at the player's position
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
            _numSeedsLeft--;
            _numSeedsPlanted++;
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
}
