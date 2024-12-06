
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class CharaterSelectionUI : MonoBehaviour
{
    private int index;
    [SerializeField] GameObject[] characters;
    [SerializeField] GameObject[] characterPrefabs;

    public static GameObject selectedCharacter;

    [SerializeField] Button prevButton;  // Tham chiếu đến nút "Trước"
    [SerializeField] Button nextButton;  // Tham chiếu đến nút "Tiếp theo"

    void Start()
    {
        index = 0;  // Đặt chỉ số ban đầu
        SelectCharacter();
          // Cập nhật trạng thái các nút ngay từ đầu
    }

    public void OnPrevBtnClick()
    {
        // Nếu index > 0, giảm index và cập nhật trạng thái
        if (index > 0)
        {
            index--;  // Giảm index
            SelectCharacter();  // Cập nhật nhân vật
             // Cập nhật trạng thái nút
        }
    }

    public void OnNextBtnClick()
    {
        // Nếu index < characters.Length - 1, tăng index và cập nhật trạng thái
        if (index < characters.Length - 1)
        {
            index++;  // Tăng index
            SelectCharacter();  // Cập nhật nhân vật
              // Cập nhật trạng thái nút
        }
    }

    private void SelectCharacter()
    {
        // Cập nhật nhân vật được chọn dựa trên index
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == index)
            {
                // Kích hoạt nhân vật được chọn
                characters[i].GetComponent<SpriteRenderer>().color = Color.white;
                characters[i].GetComponent<Animator>().enabled = true;
                selectedCharacter = characterPrefabs[i];  // Lưu lại nhân vật đã chọn
            }
            else
            {
                // Tắt các nhân vật không được chọn
                characters[i].GetComponent<SpriteRenderer>().color = Color.black;
                characters[i].GetComponent<Animator>().enabled = false;
            }
        }
    }

    private void UpdateButtonStates()
    {
        // Vô hiệu hóa nút "Trước" nếu đã ở nhân vật đầu tiên
        prevButton.interactable = index > 0;

        // Vô hiệu hóa nút "Tiếp theo" nếu đã ở nhân vật cuối cùng
        nextButton.interactable = index < characters.Length - 1;
    }

    public void OnPlayBtnClick()
    {
        // Chuyển sang màn hình "Home" khi nhấn nút "Chơi"
        SceneManager.LoadScene("Home");
    }
}

/*
public class CharaterSelectionUI : MonoBehaviour
{
    private int index;
    [SerializeField] GameObject[] characters;

    [SerializeField] GameObject[] characterPrefabs;

    public static GameObject selectedCharacter;
    void Start()
    {
        index = 0;
        SelectCharacter();
        
    }

    public void OnPrevBtnClick()
    {
        if (index > 0)
        {
            index--;
        }
        SelectCharacter();


    }

    public void OnNextBtnClick()
    {
        
        if (index< characters.Length - 1)
        {
            index++;
        }
        SelectCharacter();


    }

    private void SelectCharacter()
    {
        for (int i=0;i< characters.Length; i++)
        {
            if (i == index)
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.white;
                characters[i].GetComponent<Animator>().enabled = true;
                selectedCharacter = characterPrefabs[i];
                
            }
            else
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.black;
                characters[i].GetComponent<Animator>().enabled = false;
            }
            
        }


    }

    public void OnPlayBtnClick()
    {
        SceneManager.LoadScene("Home");
    }

}
*/
