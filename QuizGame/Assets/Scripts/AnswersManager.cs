using UnityEngine;
using TMPro;

public class AnswersManager : MonoBehaviour
{
    public GameObject model;
    private TextMeshPro text;
    private readonly float fadeTime = 10f;
    private bool displayInfo;
    private string description;

    private void Start()
    {
        text = model.GetComponentInChildren<TextMeshPro>();
        text.color = Color.clear;
  
    }
    void Update()
    {
        ShowText();
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnMouseOver()
    {
        displayInfo = true;
    }

    private void OnMouseExit()
    {
        displayInfo = false;
    }

    /* show the model name and its city */
    private void ShowText()
    {
        if (displayInfo) {
            if(model.name == "Eiffel") {
                description = "Eiffel-Paris";
            }else if(model.name == "Pisa") {
                description = "Pisa-Pisa";
            }else if (model.name == "petronas_layer1")
            {
                description = "Petronas-Kuala Lumpur";
            }else if(model.name == "Bigben") {
                description = "Bigben-London";
            }else if (model.name == "Parliament_Budapest")
            {
                description = "Parliament-Budapest";
            }else if(model.name == "HimejiCastle") {
                description = "Himeji-Himeji";
            }else if(model.name== "SagradaFamilia") {
                description = "Sagrada Familia Barcelona";
            }else if(model.name == "LibertyStatue") {
                description = "Statue of Liberty New York";
            }else if (model.name == "Capitol")
            {
                description = "Capitol- DC Washington";
            }else if (model.name == "Tajmahal")
            {
                description = "Tajmahal-Agra";
            }else if (model.name== "NeuschwansteinCastle") 
            {
                description = "Neuschwanstein Schwangau";
            }else if (model.name== "SydneyOpera") 
            {
                description = "Sydney Opera House";
            }else if (model.name == "Moscow") 
            {
                description = "Saint Basil's Cathedral Moscow";
            }else if(model.name == "Colosseum") 
            {
                description = "Colosseum Rome";
            }else if(model.name== "CampNou") 
            {
                description = "Camp Nou Barcelona";
            }else if (model.name == "CNTower")
            {
                description = "CN Tower Toronto";
            }else if (model.name == "DuomoDiMilano")
            {
                description = "Duomo di Milano Milan";
            }else if (model.name == "BlueMosqueTurkey")
            {
                description = "Blue Mosque Istanbul";
            }else if (model.name == "BurjDubai")
            {
                description = "Bruj Khalifa Dubai";
            }else if (model.name == "EmpireState")
            {
                description = "Empire State New York";
            }else if (model.name == "BeijingForbiddenCity")
            {
                description = "Beijing Forbidden City";
            }else if(model.name == "GreeceParthenon") {
                description = "Parthenon Athens";
            }else if(model.name== "GherkinLondon") {
                description = "Gherkin London";
            }else if (model.name == "LotusTemple")
            {
                description = "Lotus Temple Delhi";
            }else if (model.name == "DancingHouse")
            {
                description = "Dancing House Prague";
            }else if (model.name == "DancingHouse")
            {
                description = "Dancing House Prague";
            }else if (model.name == "GuggenheimMuseum")
            {
                description = "Guggenheim Museum New York";
            }else if (model.name == "KaabaMecca")
            {
                description = "Kaaba Mecca";
            }else if (model.name == "DomBerlin")
            {
                description = "Berlin Cathedral";
            }else if (model.name == "Baiterek")
            {
                description = "Baiterek Astana";
            }
            else if (model.name == "Taipei101")
            {
                description = "Taipei 101 ";
            }
            text.text = description;
            text.color = Color.Lerp(text.color, Color.white, fadeTime * Time.deltaTime);
        }
        else {

            text.color = Color.Lerp(text.color, Color.clear, fadeTime * Time.deltaTime);
        }

    }
}
