using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoPlayer : MonoBehaviour, iMoverse
{
    // Start is called before the first frame update
    private Rigidbody2D rb2d;

    public int Muertes;
    public int nivel;

    [Header("Movimiento")]

    private float inputX;
    private float movimientoHorizontal = 0f;
    [SerializeField] private float velocidadDeMovimiento;
    [Range(0, 0.3f)][SerializeField] private float sueavizadoDeMovimiento;
    private Vector3 velocidad = Vector3.zero;
    private bool mirarDerecha = true;

    [SerializeField] private int NumScene;


    [Header("Salto")]

    [SerializeField] private float fuerzaDeSalto;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private LayerMask Pinchos;
    [SerializeField] private LayerMask PassN;
    [SerializeField] private Transform controladorSuelo;
    [SerializeField] private Transform controladorDaño;
    [SerializeField] private Vector3 dimensionesCaja;
    [SerializeField] private Vector3 dimensionesCajaDaño;
    [SerializeField] private bool enSuelo = false;
    [SerializeField] private bool enPinchos = false;
    [SerializeField] private bool NPass = false;
    private bool salto = false;
    [Header("Animacion")]

    private Animator animator;


    [Header("SaltoPared")]
    [SerializeField] private Transform controladorPared;


    [SerializeField] private Vector3 dimensionesCajaPared;
    private bool enPared;
    private bool deslizando;
    [SerializeField] private float velocidadDeslizar;
    [SerializeField] private float fuerzaSaltoParedX;
    [SerializeField] private float fuerzaSaltoParedY;
    [SerializeField] private float tiempoSaltoPared;
    private bool saltandoDePared;

    [Header("Dash")]

    [SerializeField] private float velocidadDash;
    [SerializeField] private float tiempoDash;
    [SerializeField] private TrailRenderer trailRenderer;
    
    private float gravedadInicial;
    private bool puedeHacerDash = true;
    private bool sePuedeMover = true;

    private Vector3 respawn;


    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        gravedadInicial = rb2d.gravityScale;
        respawn = transform.position;
        
        Muertes = SaveSystem.LoadData(PathId.PathIdget()).Player.Intentos;
        nivel = SaveSystem.LoadData(PathId.PathIdget()).Player.NeNivel();

    }
    private void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        movimientoHorizontal = inputX * velocidadDeMovimiento;
        animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal));
        animator.SetBool("Deslizando", deslizando);

        if (Input.GetButton("Jump"))
        {
            salto = true;
        }

        if (!enSuelo && enPared && inputX != 0)
        {
            deslizando = true;
        }
        else
        {
            deslizando = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad0) && puedeHacerDash)
        {
            Sounds.instance.PlayAudio(Sounds.instance.dead);
            StartCoroutine(Dash());

        }
    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);
        enPinchos = Physics2D.OverlapBox(controladorDaño.position, dimensionesCajaDaño, 0f, Pinchos);
        NPass = Physics2D.OverlapBox(controladorDaño.position, dimensionesCajaDaño, 0f, PassN);
        animator.SetBool("enSuelo", enSuelo);
        enPared = Physics2D.OverlapBox(controladorPared.position, dimensionesCajaPared, 0f, queEsSuelo);
        if (sePuedeMover)
        {
            //Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);
            iMoverse imoverse = GetComponent<iMoverse>();
            imoverse.MoverR(movimientoHorizontal * Time.fixedDeltaTime, salto);
        }

        if (enPinchos)
        {
            //detecta si esta encima de los piunchos.. falta colocar la ainicacion de muerte por que recarga la escena 
            //Falta metodo para porder realizar este proceso
            
            Muertes++;

            PathId.Muretes = Muertes;
            transform.position = respawn;
 
            //SceneManager.LoadScene(NumScene);
        }
        if (NPass)
        {
            //xd
            
            nivel++;
            Debug.Log(nivel);
            PathId.Nivel = nivel;
            if (nivel==2)
            {
                CambiarScenne.NivelCarga("Nivel 02");
            }else if (nivel==3)
            {
                CambiarScenne.NivelCarga("Nivel 01");
            }else {
                CambiarScenne.NivelCarga("Menu");
            }

            

        }

        salto = false;

        if (deslizando)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, Mathf.Clamp(-10, -velocidadDeslizar, float.MaxValue));
        }
    }

    
    private void SaltoPared()
    {
        enPared = false;
        rb2d.velocity = new Vector2((fuerzaSaltoParedX * -inputX), fuerzaSaltoParedY);
        rb2d.AddForce(new Vector2(0f, fuerzaSaltoParedY));
        //realiza un brake..
        StartCoroutine(CambioSaltoPared());

    }
    private IEnumerator Dash()
    {
        sePuedeMover = false;
        puedeHacerDash = false;
        rb2d.gravityScale = 0;
        animator.SetTrigger("Dash");
        trailRenderer.emitting=true;
        rb2d.velocity = new Vector2(velocidadDash * transform.localScale.x, 0f);
        
        yield return new WaitForSeconds(tiempoDash);
        //Sounds.instance.PlayAudio(Sounds.instance.dead);
        sePuedeMover = true;
        puedeHacerDash = true;
        rb2d.gravityScale = gravedadInicial;
        trailRenderer.emitting=false;
    }
    IEnumerator CambioSaltoPared()
    {
        saltandoDePared = true;
        yield return new WaitForSeconds(tiempoSaltoPared);
        saltandoDePared = false;
    }
    //dice que no esta en el suelo pero agrega lafuerza al jugador 
    
    public void Girar()
    {
        mirarDerecha = !mirarDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionesCaja);
        Gizmos.DrawWireCube(controladorDaño.position, dimensionesCajaDaño);
        Gizmos.DrawWireCube(controladorPared.position, dimensionesCajaPared);
    }


    void iMoverse.MoverR(float mover, bool saltar)
    {
         if (!saltandoDePared)
        {
            Vector3 verlocidadObjetivo = new Vector2(mover, rb2d.velocity.y);
            rb2d.velocity = Vector3.SmoothDamp(rb2d.velocity, verlocidadObjetivo, ref velocidad, sueavizadoDeMovimiento);
        }
        if (mover > 0 && !mirarDerecha)
        {
            Girar();
        }
        else if (mover < 0 && mirarDerecha)
        {
            Girar();
        }
        if (enSuelo && saltar && !deslizando)
        {
            iMoverse imoverse = GetComponent<iMoverse>();
            imoverse.SaltoR();
            //Salto();
        }
        if (salto && enPared && deslizando)
        {
            //salto en pared 
            SaltoPared();
            //Salto();
        }

        
    }

    void iMoverse.SaltoR()
    {
        enSuelo = false;
        rb2d.AddForce(new Vector2(0f, fuerzaDeSalto));
    }
}