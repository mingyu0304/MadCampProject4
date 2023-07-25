using UnityEngine;
using UnityEngine.UI;
public class HPBar : MonoBehaviour
{
    public Slider slider; // 체력바로 사용할 Slider를 Inspector 창에서 연결합니다.
    // 체력바의 최대치를 설정하는 함수입니다.
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health; // 처음에는 체력이 가득 찬 상태로 시작합니다.
    }

    // 체력바의 현재 체력을 설정하는 함수입니다.
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
