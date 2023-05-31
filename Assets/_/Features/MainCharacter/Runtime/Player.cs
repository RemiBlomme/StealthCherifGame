using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        _rotation = transform.rotation.eulerAngles;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (_isCrouched)
            {
                transform.position += new Vector3(0, 0.5f, 0);
            }
            else
            {
                transform.position -= new Vector3(0, 0.5f, 0);
            }
                _isCrouched = !_isCrouched;
        }


        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += transform.forward * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            _rotation -= new Vector3(0, 1, 0) * _rotationSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(_rotation);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rotation += new Vector3(0, 1, 0) * _rotationSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(_rotation);
        }
    }

    private bool _isCrouched;
    private Vector3 _rotation;

    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
}
