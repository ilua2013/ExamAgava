using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMoney;
    [SerializeField] private ParticleSystem _particleWalk;
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _speed;
    [SerializeField] private int _health;
    [SerializeField] private int _money;

    private Rigidbody _rigidbody;
    private AudioSource _source;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Coin coin))
        {
            _money += 5;
            Destroy(coin.gameObject);
        }
    }

    private void Update()
    {
        var direction = new Vector3(_joystick.Direction.x, 0, _joystick.Direction.y) * _speed;
        _rigidbody.velocity = direction;

        if (_rigidbody.velocity != Vector3.zero && _source.isPlaying == false)
        {
            _source.Play();
            _particleWalk.Play();
        }
        else if (_source.isPlaying && _rigidbody.velocity == Vector3.zero)
        {
            _source.Stop();
            _particleWalk.Stop();
        }

        _textMoney.text = _money.ToString();
    }

    private void AddMoney(int money)
    {
        _money += money;
    }

    private void ApplyDamage(int damage)
    {
        _health -= damage;

        if (_health < 1)
            Dead();
    }

    private void Dead()
    {
        print("Помер");
    }
}
