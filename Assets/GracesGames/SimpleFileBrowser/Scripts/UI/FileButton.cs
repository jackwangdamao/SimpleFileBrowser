using UnityEngine;
using UnityEngine.EventSystems;

namespace GracesGames.SimpleFileBrowser.Scripts.UI {

    public class FileButton : MonoBehaviour, IPointerClickHandler {

        private FileBrowser _fileBrowser;
        private string _path = "";

        public void Setup(FileBrowser fileBrowser, string path) {
            _fileBrowser = fileBrowser;
            _path = path;
        }

        public void OnPointerClick(PointerEventData eventData) {
            if (eventData.clickCount != 2) return;
            _fileBrowser.FileClick(_path);
            _fileBrowser.SelectFile();
        }
    }
}
