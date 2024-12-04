using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StartMenu : MonoBehaviour
{
    public List<GameObject> MenuList; // Danh sách các mục menu
    private GameObject CurrentMenu;  // Mục menu hiện tại
    public GameObject SelectIcon;    // Biểu tượng chọn

    // Gọi hàm này khi con trỏ chuột di chuyển qua mục menu
    public void OnMenuHover(GameObject menuItem)
    {
        CurrentMenu = menuItem;

        if (SelectIcon != null)
        {
            // Di chuyển biểu tượng chọn đến vị trí mục menu hiện tại
            SelectIcon.transform.position = new Vector2(
                SelectIcon.transform.position.x,
                menuItem.transform.position.y
            );
        }
    }

    // Gọi hàm này khi người dùng click vào mục menu
    public void OnMenuClick(GameObject menuItem)
    {
        string menuName = menuItem.name; // Tên của mục menu được chọn

        // Sử dụng switch để gọi hàm tương ứng
        switch (menuName)
        {
            case "StartButton":
                StartGame();
                break;
            case "CharacterButton":
                OpenCharacterSelect();
                break;
            case "ExitButton":
                ExitGame();
                break;
            default:
                Debug.LogWarning("Unknown menu option: " + menuName);
                break;
        }
    }

    // Hàm bắt đầu game
    private void StartGame()
    {
        Debug.Log("Starting game...");
        SceneManager.LoadScene("Level01");
    }

    // Hàm mở màn hình chọn nhân vật
    private void OpenCharacterSelect()
    {
        Debug.Log("Opening character selection...");
        SceneManager.LoadScene("Character_Select");
    }

    // Hàm thoát game
    private void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();
    }
}
