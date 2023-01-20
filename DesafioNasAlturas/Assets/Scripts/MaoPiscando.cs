using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoPiscando : MonoBehaviour
{
    private SpriteRenderer imagem;
    // Start is called before the first frame update
    private void Awake()
    {
        this.imagem = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Desaparecer();
        }
    }

    private void Desaparecer()
    {
        this.imagem.enabled = false;
    }
}
