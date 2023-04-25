using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bot : MonoBehaviour
{
    public string _nuevoNombre;
    public Humano _humano;
    public Text _textoSaludo;
    private void Start()
    {
        _humano = GameObject.FindWithTag("Humano").GetComponent<Humano>();
    }
    public void Saludar()
    {
        if (_humano.Name == _nuevoNombre)
        {
            _textoSaludo.text = "Hola " + _humano.Name + ", tu nombre es " + _nuevoNombre;
            _humano.Name = _nuevoNombre;
            Invoke("BorrarSaludo", 3f);
        }
        else 
        {
            _textoSaludo.text = "Hola " + _humano.Name + ", tu nuevo nombre es " + _nuevoNombre;
            _humano.Name = _nuevoNombre;
            Invoke("BorrarSaludo", 3f);
        }
    }

    void BorrarSaludo()
    {
        _textoSaludo.text = "";
    }
        
}
