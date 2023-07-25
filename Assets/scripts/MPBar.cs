using UnityEngine;
using UnityEngine.UI;

public class MPBar : MonoBehaviour
{
    public Slider slider; // 체력바로 사용할 Slider를 Inspector 창에서 연결합니다.
    // 체력바의 최대치를 설정하는 함수입니다.
    public void SetMaxMp(float mp)
    {
        slider.maxValue = mp;
        slider.value = mp; // 처음에는 체력이 가득 찬 상태로 시작합니다.
    }

    // 체력바의 현재 체력을 설정하는 함수입니다.
    public void SetMP(float mp)
    {
        slider.value = mp;
    }
}
