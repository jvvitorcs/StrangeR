using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class EnumObjects : MonoBehaviour
{
    LevelLoader _levelLoader;
    [SerializeField] Text _textDialogue = null, _textDialogue2 = null;
    public enum Objects
    {
        bed, gun, flowers, medicine, nothing, television
    };

    public enum Scenes
    {
        scene1, scene2, scene3
    }

    public Objects _clickedObject;
    public Scenes _currentScene;
    public GameObject[] _triggers;
    public int _actualObject;
    public GameObject _television, _medicine, _gun, _flowers, _bed, _rosto;
    SpriteRenderer spriteRenderer;
    public Sprite _TVsprite;
    public AudioClip _TVSound, _LevelStart;
    static AudioSource _AudioSource;

    bool _playSoundBool, _secondtext;

    public Font font1, font2;

    //[SerializeField] float delay = 0.1f;   

    void Start()
    {
        _AudioSource = GetComponent<AudioSource>();
        //_TVSound = Resources.Load<AudioClip>("tvsound");
        //_LevelStart = Resources.Load<AudioClip>("levelstart");

        //font1 = Resources.Load("asym") as Font;
        //font2 = Resources.Load("Minecraftia-Regular") as Font;
        spriteRenderer = _television.GetComponent<SpriteRenderer>();
        _levelLoader = FindObjectOfType<LevelLoader>();
        _clickedObject = Objects.nothing;
        _actualObject = 0;

        if (_currentScene == Scenes.scene1)
        {
            _textDialogue.text = "''Preciso tomar meus remédios.''";
        }
        else if (_currentScene == Scenes.scene2)
        {
            _textDialogue.text = "''Acho melhor esconder minha arma.''";
            _AudioSource.PlayOneShot(_LevelStart);
        }
        else if (_currentScene == Scenes.scene3)
        {
            _textDialogue2.text = "TV";
            _textDialogue.text = "kdapokdopa qweuiqueoi quiusdaucnkmz e";
            _textDialogue.font = font1;
            _AudioSource.PlayOneShot(_LevelStart);
        }
    }

    void Update()
    {

        Debug.Log(_clickedObject);
        FunctionObjects();
        ScenesIndex();
        if (_actualObject == _triggers.Length && _currentScene != Scenes.scene3) // Se for o último, ele passa pra próxima fase...
        {
            _levelLoader.LoadNextScene();
        }
        else if (_actualObject == _triggers.Length && _currentScene == Scenes.scene3) // Se for a ultima fase, ele vai pra cena final...
        {
            _levelLoader.LoadLastScreen();
        }


    }

    private void ScenesIndex()
    {
        if (_levelLoader.currentSceneIndex == 2)
        {
            _currentScene = Scenes.scene1;
        }
        else if (_levelLoader.currentSceneIndex == 4)
        {
            _currentScene = Scenes.scene2;

        }
        else if (_levelLoader.currentSceneIndex == 6)
        {
            _currentScene = Scenes.scene3;

        }
    }

    private void FunctionObjects()
    {
        if (_clickedObject == Objects.bed) { BedDialogue(); }
        else
        if (_clickedObject == Objects.gun) { GunDialogue(); }
        else
        if (_clickedObject == Objects.flowers) { FlowersDialogue(); }
        else
        if (_clickedObject == Objects.medicine) { MedicineDialogue(); }
        else
        if (_clickedObject == Objects.television) { TVDialogue(); }
    }

    void BedDialogue()
    {

        if (_currentScene == Scenes.scene1)
        {
            _textDialogue.text = "";
        }
        else if (_currentScene == Scenes.scene2)
        {
            _textDialogue.text = "";
        }
        else if (_currentScene == Scenes.scene3)
        {
            if (_textDialogue2 != null)
            {
                Destroy(_textDialogue2);
            }
            _textDialogue.text = "aleatoria Qualquer palavra asdaferw vcxvdsfgtry uyikjhkiu6754 gfegreynhgfvf asdaferw vcxvdsfgtry uyikjhkiu6754 gfegreynhgfvf qrutoqwpw jdsjqi hfanasj zmcandu ouriwuerjhkfasu jklafjhqwoiruqwho aidfiqrjqkj";
            _textDialogue.font = font1;
        }
    }

    void GunDialogue()
    {
        if (_currentScene == Scenes.scene1)
        {
            _textDialogue.text = "''... Estou cansado, preciso me deitar.''";
        }
        else if (_currentScene == Scenes.scene2)
        {
            _textDialogue.text = "''Preciso checar minhas plantas.''";
            Destroy(_gun);
        }
        else if (_currentScene == Scenes.scene3)
        {
            _textDialogue.text = "";
        }
    }

    void FlowersDialogue()
    {
        if (_currentScene == Scenes.scene1)
        {
            _textDialogue.text = "''Onde está minha arma?''";
        }
        else if (_currentScene == Scenes.scene2)
        {
            _textDialogue.text = "''Será que há algum filme passando na TV?''";
        }
        else if (_currentScene == Scenes.scene3)
        {
            if(_textDialogue2 != null)
            {
                Destroy(_textDialogue2);
            }
            _textDialogue.text = "Qualquer aleatoria palavra qrutoqwpw jdsjqi hfanasj zmcandu ouriwuerjhkfasu jklafjhqwoiruqwho aidfiqrjqkj hdbnmcah euqwysb bahgeqwuyt mnczqweyriaockasj27291 jdsjqi hfanasj zmcandu asdaferw vcxvdsfgtry uyikjhkiu6754 gfegreynhgfvf";
            _textDialogue.font = font1;
        }
    }

    void MedicineDialogue()
    {
        if (_currentScene == Scenes.scene1)
        {
            _textDialogue.text = "''Vou checar minhas plantas.''";
            Destroy(_medicine);
        }
        else if (_currentScene == Scenes.scene2)
        {
            _textDialogue.text = "''Vou arrumar a cama hoje.''";
            Destroy(_medicine);
        }
        else if (_currentScene == Scenes.scene3)
        {
            if (_textDialogue2 != null)
            {
                Destroy(_textDialogue2);
            }
            _textDialogue.text = "Qualquer palavra aleatoria dkpoaskdapso kdopashurewui cnnquy jwqy hdbnmcah euqwysb bahgeqwuyt mnczqweyriaockasj27291 jdsjqi hfanasj zmcandu ouriwuerjhkfasu jklafjhqwoiruqwho aidfiqrjqkj asdaferw vcxvdsfgtry";
            _textDialogue.font = font1;
        }
    }

    void TVDialogue()
    {
        if (_currentScene == Scenes.scene1)
        {
            _textDialogue.text = "";
        }
        else if (_currentScene == Scenes.scene2)
        {

            spriteRenderer.sprite = _TVsprite;
            if (!_playSoundBool)
            {
                _AudioSource.PlayOneShot(_TVSound);
                _playSoundBool = true;
                _medicine.GetComponent<Collider2D>().enabled = false;
            }
            if (!_AudioSource.isPlaying && _playSoundBool)
            {
                _textDialogue.text = "''Preciso tomar meus remédios .''";
                _medicine.GetComponent<Collider2D>().enabled = true;
            }
        }
        else if (_currentScene == Scenes.scene3)
        {

            spriteRenderer.sprite = _TVsprite;

            if (!_playSoundBool)
            {
                FindObjectOfType<MusicsPlayer>().DestroyThis();
                _AudioSource.PlayOneShot(_TVSound);
                _playSoundBool = true;
                _television.GetComponent<Collider2D>().enabled = false;
                _medicine.GetComponent<Collider2D>().enabled = false;
                _flowers.GetComponent<Collider2D>().enabled = false;
                _bed.GetComponent<Collider2D>().enabled = false;
                Destroy(_rosto);
           }
            if (!_AudioSource.isPlaying && _playSoundBool && !_secondtext)
            {
                if (_textDialogue2 != null)
                {
                    Destroy(_textDialogue2);
                }
                _textDialogue.font = font2;
                _textDialogue.text = "''Hoje fazem 2 anos desde o fim da quarentena na região, se estipula que cerca de 40% da população ainda tem medo de sair de casa.''";
                Invoke("ChangeText", 7);
                _secondtext = true;

            }
        }

    }

    void ChangeText()
    {
        _television.GetComponent<Collider2D>().enabled = true;
        _medicine.GetComponent<Collider2D>().enabled = true;
        _flowers.GetComponent<Collider2D>().enabled = true;
        _bed.GetComponent<Collider2D>().enabled = true;
        _textDialogue.text = "''Realmente, Patrícia! O mundo enlouqueceu de fato nesse tempo. Não sabemos ao certo por quanto mais tempo viveremos com essa ferida por conta do isolamento.''";
        CancelInvoke("ChangeText");
        //_actualObject += 1;
    }



    public void DesactiveTrigger()
    {

        _triggers[_actualObject].GetComponent<Collider2D>().enabled = false;
        if (_actualObject != _triggers.Length - 1) //Se for o último item, ele não avança o array.
        {
            _triggers[_actualObject + 1].GetComponent<Collider2D>().enabled = true;
        }
        _actualObject += 1;
        Debug.Log(_actualObject);


    }

}
