using UnityEngine;
using UnityEngine.UI;

public class UpdatePopup : MonoBehaviour
{
    [Header("Popup")]
    public GameObject updatePanel;

    public GameObject blurBackground;

    [Header("Panel Menu")]
    public CanvasGroup panelMenuCanvas;

    [Header("Text")]
    public Text versionText;
    public Text patchText;

    private const string PREF_KEY = "LastVersion";

    private void Start()
    {

        string currentVersion = Application.version;
        string lastVersion = PlayerPrefs.GetString(PREF_KEY, "");

        if (lastVersion != currentVersion)
        {
            ShowPatch(currentVersion);

            PlayerPrefs.SetString(PREF_KEY, currentVersion);
            PlayerPrefs.Save();
        }
        else
        {
            updatePanel.SetActive(false);
        }
    }

    private void ShowPatch(string version)
    {
        blurBackground.SetActive(true);

        panelMenuCanvas.interactable = false;
        panelMenuCanvas.blocksRaycasts = false;

        // Tampilkan Update Panel
        updatePanel.SetActive(true);

        versionText.text = "Version " + version;

        if (version == "1.3")
        {
            patchText.text =
                "<color=#3E7C17><b>NEW BIRDS</b></color>\n" +
                "<i>" +
                "\t• Burung Hantu\n" +
                "\t• Burung Pelatuk\n" +
                "\t• Burung Kacer\n" +
                "\t• Burung Walet\n" +
                "\t• Burung Gagak\n" +
                "\t• Burung Kasuari\n" +
                "\t• Burung Kutilang" +
                "</i>\n\n" +
                "<color=#3E7C17><b>IMPROVEMENTS</b></color>\n" +
                "<i>" +
                "\t• Loading model lebih cepat\n" +
                "\t• Penambahan model burung omnivora\n" +
                "</i>";
        }
        else
        {
            patchText.text =
                "Terima kasih telah memperbarui aplikasi Bird Land.";
        }
    }

    public void ClosePopup()
    {
        blurBackground.SetActive(false);

        panelMenuCanvas.interactable = true;
        panelMenuCanvas.blocksRaycasts = true;

        updatePanel.SetActive(false);
    }
}