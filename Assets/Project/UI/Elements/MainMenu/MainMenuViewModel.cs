using UnityEngine;
using UnityEngine.UIElements;

namespace Project.UI
{
  public class MainMenuViewModel : MonoBehaviour
  {
    private VisualElement _mainMenu;
    private UIDocument _uiDoccument;

    public Label GameTitle { get; private set; }
    public Button PlayButton { get; private set; }
    public Button SettingsButton { get; private set; }
    public Button QuitButton { get; private set; }

    private void Awake()
    {
      _uiDoccument = GetComponent<UIDocument>();
      _mainMenu = _uiDoccument.rootVisualElement;

      GameTitle = _mainMenu.Q<Label>(nameof(GameTitle));
      PlayButton = _mainMenu.Q<Button>(nameof(PlayButton));
      SettingsButton = _mainMenu.Q<Button>(nameof(SettingsButton));
      QuitButton = _mainMenu.Q<Button>(nameof(QuitButton));
    }

    private void OnEnable()
    {
      PlayButton.clicked += OnPlayButtonClicked;
      SettingsButton.clicked += OnSettingsButtonClicked;
      QuitButton.clicked += OnQuitButtonClicked;
    }

    private void OnDisable()
    {
      PlayButton.clicked -= OnPlayButtonClicked;
      SettingsButton.clicked -= OnSettingsButtonClicked;
      QuitButton.clicked -= OnQuitButtonClicked;
    }

    private static void OnPlayButtonClicked()
    {
      Debug.Log("OnPlayButtonClicked");
    }

    private static void OnSettingsButtonClicked()
    {
      Debug.Log("OnSettingsButtonClicked");
    }

    private static void OnQuitButtonClicked()
    {
      Application.Quit();
    }
  }
}