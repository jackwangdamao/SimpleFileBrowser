using UnityEngine;
using UnityEngine.EventSystems;

namespace GracesGames.SimpleFileBrowser.Scripts.UI {

    public class FileButton : MonoBehaviour, IPointerClickHandler {

        // The file browser using this file button
        private FileBrowser _fileBrowser;

        // The path of the button
        private string _path = "";

        // Set variables, called by UserInterface script
        public void Setup(FileBrowser fileBrowser, string path) {
            _fileBrowser = fileBrowser;
            _path = path;
        }

        // When double clicked, click file and select file
        public void OnPointerClick(PointerEventData eventData) {
            if (eventData.clickCount != 2) return;
            _fileBrowser.FileClick(_path);
            _fileBrowser.SelectFile();
        }
    }
}
